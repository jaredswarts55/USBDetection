using System;

namespace BoundScriptAPI
{
    public abstract class IBoundScript
    {
        public string PlugInDisplayName;
        public string usbUniqueID;
        public string OnInsertPath;
        public string OnInsertArgs;
        public string OnRemovePath;
        public string OnRemoveArgs;
        public abstract void RunInsertScript(USBEventArgs e);
        public abstract void RunRemoveScript(USBEventArgs e);
    }
}
