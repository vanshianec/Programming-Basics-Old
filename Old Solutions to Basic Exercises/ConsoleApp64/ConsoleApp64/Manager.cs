using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp64
{
    class Manager
    {
        public string Name { get; set; }
        public int Internship { get; set; }
        public double Salary { get; set; }
        public int PeopleManageCount { get; set; }

        public Manager(string Name,int Internship,double Salary,int PeopleManageCount)
        {
            this.Name = Name;
            this.Internship = Internship;
            this.Salary = Salary;
            this.PeopleManageCount = PeopleManageCount;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Internship: {Internship}, " +
                $"Salary: {Salary}, PeopleManageCount: {PeopleManageCount}");

        }


    }
}
