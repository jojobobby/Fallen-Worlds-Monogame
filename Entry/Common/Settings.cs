using Entry.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entry.Common
{
    public static class Settings
    {
        public static string AssetsDirectory;
        
        public static void Init()
        {
            if (!File.Exists("Settings.xml"))
                throw new Exception("Settings.xml was not found.");

            XElement data = XElement.Parse(File.ReadAllText("Settings.xml"));
            AssetsDirectory = data.ParseString("@AssetsDirectory", "Common/Assets");
        }
    }
}
