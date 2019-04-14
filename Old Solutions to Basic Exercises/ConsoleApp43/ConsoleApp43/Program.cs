using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(input!="end")
            {

            string pattern = @"<a\s(href="".+"")>(.+)<\/a>";
            string replacement = @"[URL $1]$2[[/URL]";



             Console.WriteLine(Regex.Replace(input, pattern, replacement));
                input = Console.ReadLine();
            }






        }
    }
}
