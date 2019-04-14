using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            string secondInput = Console.ReadLine();
            int secondInputNumber = 0;
            try
            {
                secondInputNumber = int.Parse(secondInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int staj = int.Parse(Console.ReadLine());

            


        }
    }
}
