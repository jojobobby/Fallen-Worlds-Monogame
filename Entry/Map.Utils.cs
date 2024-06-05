using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entry
{
    partial class Map
    {
        public bool IsRectOccupied(Vector2 position)
        {
            foreach (var StaticObject in this.StaticObjects)
            {
                if (StaticObject.Position_ == position)
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}
