using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp37
{
    class Program
    {
        public static void Main(string []args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(countTrailingZeros(findFactorial(number)));
        }
        static BigInteger findFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int countTrailingZeros(BigInteger factorial)
        {
            int counter = 0;
            while (factorial % 10 == 0)
            {
                counter++;
                factorial /= 10;
            }
            return counter;
        }

    }
    
}

