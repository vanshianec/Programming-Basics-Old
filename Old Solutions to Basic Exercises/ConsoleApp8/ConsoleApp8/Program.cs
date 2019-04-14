using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool statement = false;
            for (int i = 0; i < text.Length-1; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        statement = true;
                        Console.WriteLine(text[j] + " " + i + " " + j + " ");
                        return;
                    }
                }
            }
            if (statement == false)
            {
                Console.WriteLine("No");

            }
        }
    }
}
