using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] set = { 1, 2, 3, 4 };

            int[] array = new int[2];

            vectors(set, array, 0, 0);

        }
        public static void vectors(int[] set, int[] array, int number, int n)
        {
            if (number >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }
            else
            {

                for (int i=n;i<set.Length;i++)
                {
                    array[number] = set[i];
                    vectors(set, array, number + 1, n + 1);
                }





            }
        }


    }
}


