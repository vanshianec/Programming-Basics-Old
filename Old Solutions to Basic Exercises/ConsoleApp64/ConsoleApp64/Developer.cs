using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp64
{
    class Developer
    {
        public string Name { get; set; }
        public int Internship { get; set; }
        public double Salary { get; set; }
        public bool KnowsCSharp { get; set; }
        public bool KnowsCpp { get; set; }

        public Developer(string Name,int Internship,double Salary,bool KnowsCSharp,bool KnowsCpp)
        {
            this.Name = Name;
            this.Internship = Internship;
            this.Salary = Salary;
            this.KnowsCSharp = KnowsCSharp;
            this.KnowsCpp = KnowsCpp;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Internship: {Internship}, " +
                $"Salary: {Salary}, KnowsCSharp: {KnowsCSharp}, " +
                $"KnowsCpp: {KnowsCpp}");

        }

    }
}
