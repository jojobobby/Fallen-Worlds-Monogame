using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entry.Common.Assets.Textures
{
    public static class TextureUtils
    {
        public static Point IndexToPosition(ushort index, int maxElements = 16)
        {
            Debug.WriteLine(index + " - x");

            if (index == 0)
                return new Point(0, 0);

            var x = maxElements % index;
            var y = index / maxElements;


            return new Point(x, y);
        }

    }
}
