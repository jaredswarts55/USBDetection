using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using BoundScriptAPI;

namespace USBDetection
{
    public partial class Form1 : Form
    {
        IDeviceNotifier deviceN = DeviceNotifier.OpenDeviceNotifier();
        List<ExternalProcess> allScripts = new List<ExternalProcess>();
        bool hidden = false;
        string scriptPath = @"Script.xml";

        public Form1(string[] args)
        {
            if (args.Count() > 0)
            {
                List<string> argsList = args.ToList<string>().ConvertAll(item => item.ToLower());
                if (argsList.Contains("--hide"))
                {
                    hidden = true;
                }
                int j = -1;
                if ((j = argsList.IndexOf("-p")) > -1)
                {
                    scriptPath = argsList[j + 1];
                }
            }
            InitializeComponent();
        }
        private string getUniqueUSBID(LibUsbDotNet.DeviceNotify.Info.IUsbDeviceNotifyInfo e)
        {
            return e.ClassGuid + e.SerialNumber;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new ExternalProcess().PlugInDisplayName);
            
            deviceN.OnDeviceNotify+=new EventHandler<DeviceNotifyEventArgs>(deviceN_OnDeviceNotify);
            allScripts = BoundScriptXML.Load(scriptPath);
            foreach (ExternalProcess b in allScripts)
            {
                lb_USBDevices.Items.Add(b.usbUniqueID);
            }
        }
        private void clearAllFields()
        {
            txt_InsertArgs.Text = string.Empty;
            txt_InsertPath.Text = string.Empty;
            txt_RemoveArgs.Text = string.Empty;    
            txt_RemovePath.Text = string.Empty;   
        }
        private void deviceN_OnDeviceNotify(object sender, DeviceNotifyEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    deviceN_OnDeviceNotify(sender, e);
                });
            }
            if (e.Device != null)
            {
                if (!lb_USBDevices.Items.Contains(getUniqueUSBID(e.Device)))
                {
                    lb_USBDevices.Items.Add(getUniqueUSBID(e.Device));
                }
                if (cb_ProcessEvents.Checked)
                {
                    foreach (ExternalProcess b in allScripts)
                    {
                        if (b.usbUniqueID == getUniqueUSBID(e.Device).ToString())
                        {
                            if (e.EventType == EventType.DeviceArrival)
                            {
                                try
                                {
                                    b.RunInsertScript(new BoundScriptAPI.USBEventArgs(getUniqueUSBID(e.Device).ToString()));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                }
                            }

                            if (e.EventType == EventType.DeviceRemoveComplete)
                            {
                                try
                                {
                                    b.RunRemoveScript(new BoundScriptAPI.USBEventArgs(getUniqueUSBID(e.Device).ToString()));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb_USBDevices.SelectedIndices.Count < 1)
                return;
            ExternalProcess bound = new ExternalProcess();
            bound.usbUniqueID = lb_USBDevices.SelectedItem.ToString();
            bound.OnInsertPath = txt_InsertPath.Text;
            bound.OnInsertArgs = txt_InsertArgs.Text;
            bound.OnRemovePath = txt_RemovePath.Text;
            bound.OnRemoveArgs = txt_RemoveArgs.Text;
            bound.PlugInDisplayName = comboBox1.Text;
            for(int i=0;i<allScripts.Count;i++)
            {
                if (allScripts[i].usbUniqueID == bound.usbUniqueID)
                {
                    allScripts.RemoveAt(i);
                }
            }
            allScripts.Add(bound);

            BoundScriptAPI.BoundScriptXML.Save(allScripts,scriptPath);
        }

        private void btn_RemoveBrowse_Click(object sender, EventArgs e)
        {
            ofd_Remove.ShowDialog();
        }

        private void ofd_Insert_FileOk(object sender, CancelEventArgs e)
        {
            txt_InsertPath.Text = ofd_Insert.FileNames[0];
        }

        private void ofd_Remove_FileOk(object sender, CancelEventArgs e)
        {
            txt_RemovePath.Text = ofd_Remove.FileNames[0];
        }

        private void btn_InsertBrowse_Click(object sender, EventArgs e)
        {
            ofd_Insert.ShowDialog();
        }

        private void updatePageInformation()
        {
            clearAllFields();
            if (lb_USBDevices.SelectedIndices.Count > 0)
            {
                string temp = lb_USBDevices.SelectedItem.ToString();
                foreach (ExternalProcess b in allScripts)
                {
                    if (temp == b.usbUniqueID)
                    {
                        txt_InsertArgs.Text = b.OnInsertArgs;
                        txt_InsertPath.Text = b.OnInsertPath;
                        txt_RemoveArgs.Text = b.OnRemoveArgs;
                        txt_RemovePath.Text = b.OnRemovePath;
                    }
                }
            }
        }
        private void lb_USBDevices_MouseClick(object sender, MouseEventArgs e)
        {
            updatePageInformation();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            deviceN.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (hidden)
            {
                cb_ProcessEvents.Checked = true;
                this.Visible = false;
            }
            comboBox1.Text = new ExternalProcess().PlugInDisplayName;
            if (lb_USBDevices.Items.Count > 0)
            {
                lb_USBDevices.SelectedIndex = 0;
                updatePageInformation();
            }
        }
    }
}
