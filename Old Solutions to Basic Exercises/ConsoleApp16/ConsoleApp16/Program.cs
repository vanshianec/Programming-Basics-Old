using System;
using System.Numerics;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger key = BigInteger.Parse(Console.ReadLine());
            double siteLoss = 0;
            string[] array = new string[number];

            for (int i = 0; i < number; i++)
            {


                string siteName = Console.ReadLine();
                int siteVisits = int.Parse(Console.ReadLine());
                double siteCommercialPricePerVisit = Convert.ToDouble(Console.ReadLine());
                array[i] = siteName;
                siteLoss += siteVisits * siteCommercialPricePerVisit;



            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine($"Total Loss: {siteLoss:F20}");
            Console.Write("Security Token: ");
            Console.WriteLine(BigInteger.Pow(key, number));
        }
    }
}
