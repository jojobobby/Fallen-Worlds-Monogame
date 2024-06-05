using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public partial class Square
    {
        private Texture2D Texture;

        private Map Map;

        public bool Visible = true;

        public int X;

        public int Y;

        public Square(Map map, int x, int y)
        {
            this.Map = map;
            this.X = x * Square.SIZE;
            this.Y = y * Square.SIZE;
        }

        public void Initialize()
        {
            this.Texture = this.Map.GameSprite.Content.Load<Texture2D>("Square");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Not very necessary but incase I want to load tons of tiles, we can save to memory and use !visible to not draw
            if (!Visible) 
            {
                return;
            }

            spriteBatch.Draw(this.Texture, this.Rectangle, Color.White);
        }
    }
}
