using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //GET LONGEST SEQUENCE OF EQUAL NUMBERS
            List<int> numbers = Console.ReadLine().Split(' ').Select(
                int.Parse).ToList();

            List<int> LongestSequenceOfEqualNumbers
                = GetLongestSequenceOfEqualNumbers(numbers);
            Console.WriteLine(String.Join(", ", LongestSequenceOfEqualNumbers));

        }

        public static List<int> GetLongestSequenceOfEqualNumbers(List<int> numbers)
        {
            int bestCount = 0;
            int count = 1;
            int indexNumber = 0;
            int lastIndex = 0;
            List<int> LongestSequenceOfEqualNumbers = new List<int>();
            for (int i=0;i<numbers.Count-1;i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        indexNumber = numbers[i];
                        lastIndex = i + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i=lastIndex-(bestCount-1);i<=lastIndex;i++)
            {
                LongestSequenceOfEqualNumbers.Add(numbers[i]);
            }
           
            return LongestSequenceOfEqualNumbers;
            

        }
    }
}
