using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Entry.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace Entry.Common
{

    public static class Resources
    {
        //Objects
        public static Dictionary<string, ObjectDesc> IdLower2Object = new Dictionary<string, ObjectDesc>();
        public static Dictionary<ushort, ObjectDesc> Type2Object = new Dictionary<ushort, ObjectDesc>();
        public static Dictionary<ushort, TextureDesc> Type2Texture = new Dictionary<ushort, TextureDesc>();

        //Grounds
        public static Dictionary<ushort, GroundDesc> Type2Ground = new Dictionary<ushort, GroundDesc>();
        public static Dictionary<ushort, TextureDesc> Type2GroundTexture = new Dictionary<ushort, TextureDesc>();

        public static void Init(GraphicsDevice graphicsData)
        {
            LoadGameData(graphicsData);
        }

        public static void LoadGameData(GraphicsDevice graphicsData)
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
                        case "Player":
                            IdLower2Object[id.ToLower()] = Type2Object[type] = new PlayerDesc(element, id, type);
                            break;
                        default:
                            IdLower2Object[id.ToLower()] = Type2Object[type] = new ObjectDesc(element, id, type);
                            break;
                    }

                    var texture = element.Element("Texture") ?? throw new Exception($"Texture not found. Type: {type} Id:{id}");
                    Type2Texture[type] = new TextureDesc(graphicsData, texture);
                }

                foreach (var element in data.Elements("Ground"))
                {
                    var id = element.ParseString("@id");
                    var type = element.ParseUshort("@type");

                    if (string.IsNullOrWhiteSpace(id))
                        throw new Exception("Invalid ID.");
                    if (Type2Ground.ContainsKey(type))
                        throw new Exception($"Duplicate type <{id}:{type}>");

                    Type2Ground[type] = new GroundDesc(element, id, type);

                    var texture = element.Element("Texture") ?? throw new Exception($"Texture not found. Type: {type} Id:{id}");
                    Type2GroundTexture[type] = new TextureDesc(graphicsData, texture);
                }
            }
        } 
    }
}
