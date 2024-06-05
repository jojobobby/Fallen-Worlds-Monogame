using Entry.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public class BasicObject
    {
        public Color Color_ = Color.White;
        public Texture2D Texture_;
        public Rectangle TexturePosition;
        public Vector2 Position_;
        public Map Map_;
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(
                    (int)Position_.X, 
                    (int)Position_.Y, 
                    64,
                    64
                    );
            }
        }

        public BasicObject()
        {

        }

        public virtual void Initialize()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture_, this.Rectangle, this.TexturePosition, this.Color_);
        }
    }
}
