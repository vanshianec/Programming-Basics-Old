using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"([$]{6,10}|[@]{6,10}|[#]{6,10}|[<]{6,10})";
            foreach (var element in input)
            {
                if (element.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                MatchCollection matches = Regex.Matches(element, pattern);

                if (matches.Count == 2)
                {

                   if(matches[0].Length==matches[1].Length)
                    {
                        char character = 'a';
                        foreach (char item in matches[1].Value)
                        {
                            character = item;
                        }
                        if (matches[1].Length == 10)
                        {
                            Console.WriteLine($"ticket \"{element}\" - {matches[1].Length}{character} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{element}\" - {matches[1].Length}{character}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{element}\" - no match");

                }


                }


            }




        }
    }
}
