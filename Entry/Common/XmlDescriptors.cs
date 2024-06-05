using Entry.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entry.Common
{
    public struct TextureDesc
    {
        public string File;
        public ushort Index;
        public TextureDesc(XElement e)
        {
            this.File = e.ParseString("File");
            this.Index = e.ParseUshort("Index");
        }

    }
    public class ObjectDesc
    {
        public string Id;
        public int Type;

        public TextureDesc Texture; 
        public ObjectDesc(XElement e, string id, int type)
        {
            this.Id = id;
            this.Type = type;

            var texture = e.Element("Texture") ?? throw new Exception($"Texture not found. Type: {Type} Id:{Id}");
            this.Texture = new TextureDesc(texture);
        }


    }
}
