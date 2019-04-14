using System;
using System.Collections.Generic;
using System.Linq;
namespace LinearDataStructures_Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORT LIST OF NUMBERS

            List<int> numbers = Console.ReadLine().Split(' ').Select(
                int.Parse).ToList();

            //1.1 CUSTOM SORT

            for (int i=0;i<numbers.Count-1;i++)
            {
                for (int j=i+1;j<numbers.Count;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i]=numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //1.2 REVERSE SORT WITH LINQ

            numbers = numbers.OrderByDescending(x => x).ToList();

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

           
        }
    }
}
