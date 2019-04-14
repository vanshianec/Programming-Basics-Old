using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp68
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(Point a,Point b)
        {
            X = b.X - a.X;
            Y = b.Y - a.Y;
        }
    }
}
