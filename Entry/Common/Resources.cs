using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Entry.Utils;

namespace Entry.Common
{
    public static class Resources
    {
        public static Dictionary<string, ObjectDesc> IdLower2Object = new Dictionary<string, ObjectDesc>();
        public static Dictionary<int, ObjectDesc> Type2Object = new Dictionary<int, ObjectDesc>();

        public static void Init()
        {
            LoadGameData();
        }

        public static void LoadGameData()
        {
            var paths = Directory.EnumerateFiles(Files.CombineResourcePath("GameData/"), "*.xml", SearchOption.TopDirectoryOnly).ToArray();
            foreach (var path in paths)
            {
                var data = XElement.Parse(File.ReadAllText(path));

                foreach (var element in data.Elements("Object"))
                {
                    var id = element.ParseString("@id");
                    var type = element.ParseUshort("@type");

                    if (string.IsNullOrWhiteSpace(id))
                        throw new Exception("Invalid ID.");
                    if (Type2Object.ContainsKey(type))
                        throw new Exception($"Duplicate type <{id}:{type}>");
                    if (IdLower2Object.ContainsKey(id))
                        throw new Exception($"Duplicate ID <{id}:{type}>");

                    switch (element.ParseString("Class"))
                    { 
                        //if class is Player or Item or etc
                        default:
                            IdLower2Object[id.ToLower()] = Type2Object[type] = new ObjectDesc(element, id, type);
                            break;
                    }
                }

            }




        }

    }
}
