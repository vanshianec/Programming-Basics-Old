using System;
using System.Numerics;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger M = BigInteger.Parse(Console.ReadLine());
            BigInteger Y = BigInteger.Parse(Console.ReadLine());
            BigInteger middleValue = N / 2;
            int counter = 0;
            while (N > M)
            {
                N -= M;
                if (N == middleValue)
                {
                    if (Y == 0 || Y>N)
                    {
                        continue;
                    }
                    else
                    {
                        N = N / Y;
                    }
                 
                }
                counter++;
            }
            int number = 505;
            Console.WriteLine(number * 0.5);
        }
    }
}
