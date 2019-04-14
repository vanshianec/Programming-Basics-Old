using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class Subjects
    {
        public double English { get; set; }
        public double Maths { get; set; }
        public double History { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Biology { get; set; }
        public double Geography { get; set; }
        public double Bulgarian { get; set; }

        public Subjects(double English, double Maths, double History,
            double Physics, double Chemistry,double Biology,double Geography,
            double Bulgarian)
        {
            this.English = English;
            this.Maths = Maths;
            this.History = History;
            this.Physics = Physics;
            this.Chemistry = Chemistry;
            this.Biology = Biology;
            this.Geography = Geography;
            this.Bulgarian = Bulgarian;
        }
    }
}
