using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numberOfStars = 8;
            Console.WriteLine(Returner(numberOfStars, "*")); 
            
        }
        public static String Returner(int number, String text)
        {
            String result = "";

            for (int i = 0; i < number; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
