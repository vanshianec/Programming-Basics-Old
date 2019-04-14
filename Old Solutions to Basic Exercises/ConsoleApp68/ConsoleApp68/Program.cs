using System;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 1);
            Point b = new Point(4, 2);
            Point c = new Point(1, 3);
            Point d = new Point(2, 1);
            Point o = new Point(2.53, 1.4);

            Quadrilateral q1 = new Quadrilateral(a, b, c, d);
            
            Vector v1 = new Vector(d,o);
            Vector v2 = new Vector(a,o);
            double sine= q1.GetSineBetweenTwoVectors(v1, v2);
            double d1 = a.DistanceBetweenTwoPoints(c);
            double d2 = d.DistanceBetweenTwoPoints(b);
            
         
            Console.WriteLine($"Perimeter: {q1.GetPerimeter():F2}");
            Console.WriteLine($"Area: {q1.GetArea(sine, d1, d2):F2}");

        }
    }
}
