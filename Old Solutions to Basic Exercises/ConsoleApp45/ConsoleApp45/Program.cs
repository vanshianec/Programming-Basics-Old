using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match m = Regex.Match(input, pattern);
                    if (dict.ContainsKey(m.Groups[1].Value))
                    {
                        dict[m.Groups[1].Value].Clear();
                        dict[m.Groups[1].Value].Add(m.Groups[2].Value);
                        dict[m.Groups[1].Value].Add(m.Groups[3].Value);


                    }
                    else
                    {
                        dict.Add(m.Groups[1].Value, new List<string>());
                        dict[m.Groups[1].Value].Add(m.Groups[2].Value);
                        dict[m.Groups[1].Value].Add(m.Groups[3].Value);

                    }
                }




                input = Console.ReadLine();
            }
            foreach (var element in dict.OrderBy(x=> double.Parse(x.Value[0])))
            {
                Console.WriteLine($"{element.Key} => {element.Value[0]:F2} => {element.Value[1]}");
            }
             
           


        }
    }
}
