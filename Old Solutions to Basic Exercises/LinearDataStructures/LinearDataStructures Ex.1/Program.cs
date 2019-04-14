using System;
using System.Collections.Generic;
using System.Linq;

namespace LinearDataStructures_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AVERAGE AND SUM OF NUMBERS

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());




        }
    }
}
