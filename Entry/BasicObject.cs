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
        public Color Color_;
        public Texture2D Texture_;
        public Vector2 Position_;
        public Map Map_;
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(
                    (int)Position_.X, 
                    (int)Position_.Y, 
                    100, 
                    100
                    );
            }
        }

        public BasicObject(Map map, Texture2D texture, Vector2 position)
        {
            this.Texture_ = texture;
            this.Position_ = position;
            this.Color_ = Color.White;
            this.Map_ = map;
        }

        public virtual void Initialize()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture_, this.Rectangle, this.Color_);
        }
    }
}
