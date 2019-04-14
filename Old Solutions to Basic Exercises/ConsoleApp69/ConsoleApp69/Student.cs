using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class Student
    {
        private string Name { get; set; }
        private int UCN { get; set; }
        public Subjects Subs { get; set; }

        public Student(string Name,int UCN,Subjects Subs)
        {
            this.Name = Name;
            this.UCN = UCN;
            this.Subs = Subs;
        }
        public void Print()
        {
            Console.WriteLine($"Student name: {Name}, Student UCN: {UCN}");
            Console.WriteLine($"Student grades: ");
            Console.WriteLine($"English - {Subs.English}");
            Console.WriteLine($"Maths - {Subs.Maths}");
            Console.WriteLine($"History - {Subs.History}");
            Console.WriteLine($"Physics - {Subs.Physics}");
            Console.WriteLine($"Chemistry - {Subs.Chemistry}");
            Console.WriteLine($"Biology - {Subs.Biology}");
            Console.WriteLine($"Geography - {Subs.Geography}");
            Console.WriteLine($"Bulgarian - {Subs.Bulgarian}");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

        }
    }
}
