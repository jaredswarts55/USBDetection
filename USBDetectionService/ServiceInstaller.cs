using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;


namespace USBDetectionService
{
    [RunInstaller(true)]
    public partial class USBDetectionServiceInstaller : System.Configuration.Install.Installer
    {
        public USBDetectionServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
