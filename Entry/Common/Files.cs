using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.Common
{
    public static class Files
    {
        public static void Initialize()
        {
            //TODO: might need later
        }
        public static string CombineResourcePath(string path)
        {
            return $"{Settings.AssetsDirectory}/{path}";
        }
    }
}
