using System;
using System.Linq;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int length = array1.Length;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    array1[j] = (j + k) % length;
                }
            }
            Console.WriteLine(String.Join(" ", array1));





        }
    }
}
