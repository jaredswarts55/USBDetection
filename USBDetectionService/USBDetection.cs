using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet;
using BoundScriptAPI;
using System.IO;
using LibUsbDotNet.WinUsb;

namespace USBDetectionService
{
    
    public class USBDetection
    {
        private string scriptsPath = @"c:\Scripts.xml";
        static WindowsDeviceNotifier deviceN = (WindowsDeviceNotifier) DeviceNotifier.OpenDeviceNotifier();
        List<ExternalProcess> boundScripts = new List<ExternalProcess>();
        public USBDetection()
        {

        }
        public void StartDetection()
        {
            System.Threading.Thread.Sleep(5000);
            Service1.Log("Instanciating USBDetection");
            if (File.Exists(scriptsPath))
            {
                Service1.Log("Initializing");
                deviceN.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(OnDeviceNotify);
                boundScripts = BoundScriptXML.Load(scriptsPath);
                Service1.Log(String.Format("Bound Script Loaded: {0}", boundScripts.Count));
            }
            else
            {
                Service1.Log("Scripts.xml does not exist in the location given");
            }
        }
        public void Stop()
        {
            deviceN.Enabled = false;
            deviceN.OnDeviceNotify -= new EventHandler<DeviceNotifyEventArgs>(OnDeviceNotify);
        }
        private void OnDeviceNotify(object sender, DeviceNotifyEventArgs e)
        {
            Service1.Log(String.Format("Device Notification Event: {0} | {1}", e.EventType.ToString(), e.Device.ClassGuid));
            foreach (IBoundScript b in boundScripts)
            {
                if (b.usbUniqueID == e.Device.ClassGuid.ToString())
                {
                    if (e.EventType == EventType.DeviceArrival)
                    {
                        try
                        {
                            b.RunInsertScript(new BoundScriptAPI.USBEventArgs(e.Device.ClassGuid.ToString()));
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
                            b.RunRemoveScript(new BoundScriptAPI.USBEventArgs(e.Device.ClassGuid.ToString()));
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
