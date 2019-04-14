using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            int k = int.Parse(Console.ReadLine());
            array[0] = 1;
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i - k; j < i - 1; j++)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }
            Console.WriteLine(String.Join(" ",array));




        }
    }
}
