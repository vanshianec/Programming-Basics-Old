using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
                if (sum == 12)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Not a magic matrix");
                    return;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[col, row];
                }
                if (sum == 12)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Not a magic matrix");
                    return;
                }
            }
            int firstDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                firstDiagonal += matrix[i, i];
            }
            if (firstDiagonal != 12)
            {
                Console.WriteLine("Not a magic matrix");
                return;
            }
            int secondDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                secondDiagonal += matrix[i, matrix.GetLength(1)-1-i];
            }
            if (secondDiagonal != 12)
            {
                Console.WriteLine("Not a magic matrix");
                return;
            }
            Console.WriteLine("A magic matrix!");







        }
    }
}
