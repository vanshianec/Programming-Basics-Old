using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //MAJORANT
            //EXAMPLE : {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3

            List<int> numbers = Console.ReadLine().Split(new[] { ", ", },
            StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToList();
       

            numbers.Sort();
            int majorant = numbers.Count / 2 + 1;
            int equalNumbersCount = 1;
            int majorantNumber = numbers[0];

            for (int i=0;i< numbers.Count-1;i++)
            {
                if(numbers[i]==numbers[i+1])
                {
                    equalNumbersCount++;
                    majorantNumber = numbers[i];
                    
                }
                else
                {
                    equalNumbersCount = 1;
                }

                if(equalNumbersCount >= majorant)
                {
                    Console.WriteLine(majorantNumber);
                    return;
                }

            }
            if(numbers.Count!=1)
            {
                Console.WriteLine("The majorant does not exists");
            }
            else
            {
                Console.WriteLine(majorantNumber);
            }


        }
    }
}
