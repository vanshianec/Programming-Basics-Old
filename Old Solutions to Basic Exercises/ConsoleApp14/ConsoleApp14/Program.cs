using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] array = new double[number];
            double bestsum = 0;
            int bestQuality = 0;
            double bestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;


            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double snowBallValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowBallValue > bestsum)
                {
                    bestsum = snowBallValue;
                    bestValue= snowBallValue;
                    bestQuality = snowballQuality;
                    bestSnow = snowballSnow;
                    bestTime= snowballTime ;

                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");






        }
    }
}
