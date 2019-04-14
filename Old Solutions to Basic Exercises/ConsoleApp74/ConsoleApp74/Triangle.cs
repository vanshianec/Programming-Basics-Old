using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp74
{
    class Triangle : Figure, IFigurable
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle (double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            return A * B;
        }


        public override void Draw()
        {
            Console.WriteLine("^");
        }


    }

}
