using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp68
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double X,double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double DistanceBetweenTwoPoints(Point a)
        {
            return Math.Sqrt(Math.Pow(X - a.X,2) + (Math.Pow(Y - a.Y,2)));
        }
        


    }
}
