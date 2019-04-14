using System;
using System.Linq;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
            }
            else if (array.Length%2==0)
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]} }}");
            }
           else if (array.Length%2!=0)
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2+1]} }}");
            }
            

        }
    }
}
