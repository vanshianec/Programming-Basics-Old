using System;
using System.Collections.Generic;
using System.Linq;

namespace LinearDataStructures_Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRINT NUMBERS IN REVERSE ORDER

            Stack<int> numbers =new Stack<int>
                (Console.ReadLine().Split(' ').Select(
                int.Parse));

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
           


        }
    }
}
