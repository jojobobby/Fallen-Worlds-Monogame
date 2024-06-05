using Entry.Common;
using Entry.Common.Assets.Textures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public class GameObject : BasicObject
    {
        private ushort ObjectType;
        public GameObject(Map map, ushort objectType) : base ()
        {
            this.Map_ = map;
            this.ObjectType = objectType; this.ObjectType = objectType;
            this.Texture_ = Resources.Type2Texture[ObjectType].Texture;

            var index = TextureUtils.IndexToPosition(Resources.Type2Texture[ObjectType].Index);

            this.TexturePosition = new Rectangle(index, new Point(8, 8));
        }

        public override void Update()
        {

        }
    }
}
