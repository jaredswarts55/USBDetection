using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace USBDetectionService
{
    public partial class Service1 : ServiceBase
    {
        public static TextWriter log = null;
        USBDetection usb = null;
        public Service1()
        {
            InitializeComponent();
        }
        public static void Log(string text)
        {
            log = new StreamWriter(@"c:\ServiceLog.txt",true);
            log.WriteLine(text);
            log.Close();
        }
        protected override void OnStart(string[] args)
        {
            Log("Service Started");
            usb = new USBDetection();
            System.Threading.Thread th = new System.Threading.Thread(usb.StartDetection);
            th.Start();
        }

        protected override void OnStop()
        {
            usb.Stop();
        }
    }
}
