using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAM THAT HOW MANY TIMES A NUMBER APPEARS IN AN ARRAY
            //EXAMPLE : array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
            //2 -> 2 times
            //3 -> 4 times
            //4 -> 3 times

            //first solution (longer)
            int[] array = new int[1001];

            array = Console.ReadLine().Split(new[] { ", " },
            StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();
            
            Array.Sort(array);
            int counter = 1;
            int lastIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    lastIndex = i + 1;
                }
                else
                {
                    if(counter==1)
                    {
                        lastIndex = i;
                    }
                    Console.WriteLine($"{array[lastIndex - (counter - 1)]} -> {counter}");
                    counter = 1;
                }
            }
            if(counter==1)
            {
                lastIndex = array.Length-1;
            }
            Console.WriteLine($"{array[lastIndex - (counter - 1)]} -> {counter}");
            Console.WriteLine();
            //second solution (for numbers greater than 0)
            int[] occurences = new int[1001];

            foreach (var num in array)
            {
                occurences[num]++;
            }
            for (int i=0;i<occurences.Length;i++)
            {
                if(occurences[i]!=0)
                {
                    Console.WriteLine($"{i} -> {occurences[i]}");
                }
            }




        }
    }
}
