using Entry.Utils;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entry.Common
{
    public struct TextureDesc
    {
        public Texture2D Texture;

        public string File;
        public ushort Index;
        public TextureDesc(GraphicsDevice graphicsData, XElement e)
        {
            this.File = $"{Files.CombineResourcePath("Textures")}/{e.ParseString("File")}.png";
            this.Index = e.ParseUshort("Index");

            var fileStream = new FileStream(File, FileMode.Open, FileAccess.Read);
            this.Texture = Texture2D.FromStream(graphicsData, fileStream);
        }

    }
    public class ObjectDesc
    {
        public string Id;
        public int Type;
        public ObjectDesc(XElement e, string id, int type)
        {
            this.Id = id;
            this.Type = type;
        } 
    }

    public class PlayerDesc : ObjectDesc
    {
        public PlayerDesc(XElement e, string id, int type) : base(e, id, type)
        {
            
        }
    }

    public class GroundDesc : ObjectDesc
    {
        public GroundDesc(XElement e, string id, int type) : base(e, id, type)
        {
            
        }
    }
}
