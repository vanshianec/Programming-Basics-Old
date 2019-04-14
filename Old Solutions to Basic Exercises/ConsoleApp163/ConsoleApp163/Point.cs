using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp163
{
    class Point
    {
        private double x { get; set; }
        private double y { get; set; }
                
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;

        }
                
        public double DistanceBetweenTwoPoints(Point a)
        {
            return Math.Sqrt(Math.Abs(a.x - x) + Math.Abs(a.y - y));
        }

        public void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(($"Point location: ({x}, {y})."));
        }

        public static Point operator +(Point a,Point b)
        {
            
            return new Point(a.x + b.x, a.y + b.y);
        }

        public Point Increment()
        {
            return new Point(x+1,y+1);
        }

        public static Point operator -(Point a, Point b)
        {

            return new Point(a.x - b.x, a.y - b.y);
        }
        public static bool operator !=(Point a, Point b)
        {
            if (a.x != b.x || b.y != a.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Point a, Point b)
        {
            if (a.x == b.x && b.y == a.y)
            {
                return true;
            }
            return false;
        }
     


        public static bool operator >(Point a, Point b)
        {
            if (a.x > b.x)
            {
                return true;

            }
            if (a.x == b.x)
            {
                if (a.y > b.y)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator <(Point a, Point b)
        {
            if (a.x < b.x)
            {
                return true;

            }
            if (a.x == b.x)
            {
                if (a.y < b.y)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
