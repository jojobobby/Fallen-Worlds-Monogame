using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public class MapUserInput 
    {
        public static Boolean moving_left = false;
        public static Boolean moving_right = false;
        public static Boolean moving_up = false;
        public static Boolean moving_down = false;

        public MapUserInput()
        { 

        }
        public void Update()
        {
            HandleKeys();
        }

        private void HandleKeys()
        {
            if (!moving_up && Keyboard.GetState().IsKeyDown(Keys.W))
            {
                moving_up = true;
            }
            else if (moving_up)
            {
                moving_up = false;
            }

            if (!moving_down && Keyboard.GetState().IsKeyDown(Keys.S))
            {
                moving_down = true;
            }
            else if (moving_down)
            {
                moving_down = false;
            }

            if (!moving_left && Keyboard.GetState().IsKeyDown(Keys.A))
            {
                moving_left = true;
            }
            else if (moving_left)
            {
                moving_left = false;
            }

            if (!moving_right && Keyboard.GetState().IsKeyDown(Keys.D))
            {
                moving_right = true;
            }
            else if (moving_right)
            {
                moving_right = false;
            }
        }
    }
}
