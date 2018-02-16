using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public struct DisplacementVector
    {
        public int X;
        public int Y;

        public DisplacementVector(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public static DisplacementVector operator +(DisplacementVector vec1, DisplacementVector vec2)
        {
            return new DisplacementVector(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }
    }
}
