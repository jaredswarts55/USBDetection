using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BoundScriptAPI
{
    public class ExternalProcess : IBoundScript
    {

        public ExternalProcess()
        {
            PlugInDisplayName = "Run External Processes";
        }
        public override void RunInsertScript(BoundScriptAPI.USBEventArgs e)
        {
            Process.Start(OnInsertPath, OnInsertArgs);
        }
        public override void RunRemoveScript(BoundScriptAPI.USBEventArgs e)
        {
            Process.Start(OnRemovePath, OnRemoveArgs);
        }
    }
}

