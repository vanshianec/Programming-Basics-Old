using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //start<213asfaas|end
            //saaastarthelloendsdarstartFromTheOtherenddvsefdsfstartSideend

            bool statement = false;
            string input = Console.ReadLine();

            string pattern = @"([A-Za-z]+)[\<\|\\](.*)[\<\|\\]([A-Za-z]+)";
            Match m = Regex.Match(input, pattern);
           
            string start = m.Groups[1].Value;
            string end = m.Groups[3].Value;

            string endPattern = $@"start(.+?)end";

            string input2 = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input2, endPattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Groups[1].Value);
                statement = true;
            }
            if (!statement)
            {
                Console.WriteLine("Empty result");
            }
            

        }
    }
}
