﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();


            var age = int.Parse(Console.ReadLine());


            var employeeId = int.Parse(Console.ReadLine());


            var salary = double.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {name}");


            Console.WriteLine($"Age: {age}");


            Console.WriteLine($"Employee ID: {employeeId:D8}");


            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
