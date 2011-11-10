using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BoundScriptAPI
{
    public class BoundScriptXML
    {
        private static XmlSerializer xmlS = new XmlSerializer(typeof(List<ExternalProcess>), new Type[] { typeof(ExternalProcess) });
        public static  List<ExternalProcess> Load(string path)
        {
            List<ExternalProcess> allScripts = new List<ExternalProcess>();
            if (File.Exists(path))
            {
                FileStream f = null;
                try
                {
                    f = File.Open(path, FileMode.Open);
                    allScripts = (List<ExternalProcess>)xmlS.Deserialize(f);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    if (f != null)
                        f.Close();
                }
            }
            return allScripts;
        }
        public static void Save(List<ExternalProcess> allScripts, string path)
        {
            TextWriter f = null;
            try
            {
                f = new StreamWriter(path, false);
                xmlS.Serialize(f, allScripts);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (f != null)
                    f.Close();
            }
        }
    }
}
