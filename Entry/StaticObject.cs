﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public class StaticObject : BasicObject
    {
        public StaticObject(Map map, Texture2D texture, Vector2 position) : base()
        {
            this.Map_ = map;
            this.Texture_ = texture;
            this.Position_ = position;
        }
    }
}
