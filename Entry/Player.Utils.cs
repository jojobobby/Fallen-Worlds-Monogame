using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public partial class Player : GameObject
    {
        private void Move(Vector2 position)
        {
            this.Position_ += position;
        }
        private bool CanMove(Vector2 position)
        {
            return !this.Map.IsRectOccupied(position);
        }
    }
}
