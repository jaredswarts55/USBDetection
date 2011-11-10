using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundScriptAPI
{
    public class USBEventArgs
    {
        public string usbUniqueId;
        public USBEventArgs(string USBUID)
        {
            usbUniqueId = USBUID;
        }
    }
}
