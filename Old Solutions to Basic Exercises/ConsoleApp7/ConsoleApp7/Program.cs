using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {


            pesho();




        }
        public static void pesho()
        {
            string text = Console.ReadLine();
            char[] characters = text.ToCharArray();
            int counter = 0;
            int counter2 = 0;
            bool statement = false;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (characters[i] == characters[j])
                    {
                        statement = true;
                        counter = i;
                        counter2 = j;
                        Console.WriteLine(characters[j] + " " + i + " " + j + " ");
                        return;
                    }
                }
            }
            if (statement==false)
            {
                Console.WriteLine("There are no dublicated characters in this word!");
            }
        }


    }
    }

