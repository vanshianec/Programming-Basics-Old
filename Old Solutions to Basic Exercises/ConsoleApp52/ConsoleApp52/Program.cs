using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ConsoleApp52
{
    class Program
    {

        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            string text3 = Console.ReadLine();
            string text4 = Console.ReadLine();
            string text5 = Console.ReadLine();
            
            string surface = @"([^A-Za-z\d]+)";
            string mantle = @"([\d_]+)";
            string core = @"([A-Za-z]+)";
            string middle = @"([^A-Za-z\d]+)([\d_]+)([A-Za-z]+)([\d_]+)([^A-Za-z\d]+)";
            int counter = 0;
            if (Regex.IsMatch(text1, surface))
            {

            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (Regex.IsMatch(text2, mantle))
            {
               
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (Regex.IsMatch(text3, middle))
            {
                Match m = Regex.Match(text3, middle);
                counter = m.Groups[3].Length;
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (Regex.IsMatch(text4, mantle))
            {

            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (Regex.IsMatch(text5, surface))
            {

            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            Console.WriteLine("Valid");
            Console.WriteLine(counter);


        }
    }
}
    


