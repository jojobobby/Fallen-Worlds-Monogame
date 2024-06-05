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
    public partial class Player : GameObject
    {
        private readonly float SPEED = 4;

        private Map Map;
        public Player(Map map, ushort objectType) : base(map, objectType)
        {
            this.Map = map;
        }
        public override void Update()
        {
            this.Inputs();
        }
        private void Inputs()
        {
            //TODO: add rectangle collision instead of position collision
            var yVelocity = MapUserInput.moving_down ? SPEED : MapUserInput.moving_up ? -SPEED : 0;
            var xVelocity = MapUserInput.moving_right ? SPEED : MapUserInput.moving_left ? -SPEED : 0;

            var movement = new Vector2(xVelocity, yVelocity);

            if (this.CanMove(movement))
            {
                this.Move(movement);
            }
        }
    }
}
