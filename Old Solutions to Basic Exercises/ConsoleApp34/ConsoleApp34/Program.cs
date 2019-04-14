using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int totalLiters = 255;

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                sum += quantity;
                if (sum > totalLiters)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantity;
                }
               
                
            }
            Console.WriteLine(sum);

















        }
    }
}
