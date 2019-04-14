using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ConsoleApp68
{
    class Quadrilateral
    {
        private Point A { get; set; }
        private Point B { get; set; }
        private Point C { get; set; }
        private Point D { get; set; }
       
       

        public Quadrilateral(Point A,Point B,Point C,Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        public double GetSineBetweenTwoVectors(Vector AO,Vector BO)
        {
            double Cosine= (AO.X * BO.X + AO.Y * BO.Y/
                Math.Sqrt(Math.Pow(AO.X,2)+Math.Pow(AO.Y,2))*
                Math.Sqrt(Math.Pow(BO.X,2)+Math.Pow(BO.Y,2)));

            return Math.Sqrt(1 - Math.Pow(Cosine, 2));
            

            

        }

        public double GetArea(double sine,double AO,double BO)
        {
            return AO * BO * sine / 2;
        }
        

        public double GetPerimeter()
        {
            return A.DistanceBetweenTwoPoints(B) +
                B.DistanceBetweenTwoPoints(C) +
                C.DistanceBetweenTwoPoints(D) +
                D.DistanceBetweenTwoPoints(A);
        }



    }
}
