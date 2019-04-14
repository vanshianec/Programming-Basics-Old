using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAM THAT DELETES ALL NUMBERS WHICH HAVE ODD COUNT

            //EXAMPLE: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} => {5, 3, 3, 5}

            List<int> numbers = Console.ReadLine().Split(new [] { ", "},StringSplitOptions.RemoveEmptyEntries).Select(
                int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            List<int> numbersBeforeSorting = new List<int>(numbers);
            numbers.Sort();
            int counter = 1;
            int lastIndex = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    lastIndex = i + 1;
                }
                else
                {
                    if (counter % 2 == 0)
                    {
                        evenNumbers.Add(numbers[lastIndex - (counter - 1)]);
                    }
                    counter = 1;
                }
            }
            if (counter % 2 == 0)
            {
                evenNumbers.Add(numbers[lastIndex - (counter - 1)]);
            }

            Console.WriteLine(); 
            foreach (var number in numbersBeforeSorting)
            {
                foreach (var evenNumber in evenNumbers)
                {
                    if(number == evenNumber)
                    {
                        Console.Write($"{number} ");
                        break;
                    }
                }
            }
        }
    }
}
