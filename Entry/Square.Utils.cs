using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public partial class Square
    {
        public static int SIZE = 40;
        private const float X_CENTER_OFFSET = 0.5f;
        private const float Y_CENTER_OFFSET = 0.5f;

        public Vector2 CenterPos
        {
            get
            {
                return new Vector2(
                    X + X_CENTER_OFFSET, 
                    Y + Y_CENTER_OFFSET
                    );
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(
                    (int)X,
                    (int)Y,
                    SIZE,
                    SIZE
                    );
            }
        }
    }
}
