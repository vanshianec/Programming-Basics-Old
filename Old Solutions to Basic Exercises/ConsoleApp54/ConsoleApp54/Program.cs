using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateMessagePattern = @"\b(\d+) <-> ([A-Za-z]*[\d]*[A-Za-z0-9]*$)";
            string broadCastPattern = @"(^[^\d]+) <-> ([A-Za-z]*[\d]*[A-Za-z0-9]*$)";
            var broadcasts = new Dictionary<string, List<Query>>();
            var messages = new Dictionary<string, List<Query>>();

            while (input != "Hornet is Green")
            {
                string[] command = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Query q = new Query();
                if (Regex.IsMatch(input, privateMessagePattern))
                {
                    Match m = Regex.Match(input, privateMessagePattern);
                    string recCode = m.Groups[1].Value;

                    StringBuilder str = new StringBuilder();

                    for (int i = recCode.Length - 1; i >= 0; i--)
                    {
                        str.Append(recCode[i]);

                    }
                    q.firstQuery = str.ToString();

                    q.secondQuery = m.Groups[2].Value;
                    if (messages.ContainsKey("Messages"))
                    {
                        messages["Messages"].Add(q);
                    }
                    else
                    {
                        messages.Add("Messages", new List<Query>());
                        messages["Messages"].Add(q);
                    }

                }
                else if (Regex.IsMatch(input, broadCastPattern))
                {
                    Match m = Regex.Match(input, broadCastPattern);
                    string value = m.Value.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1];
                    StringBuilder str = new StringBuilder();
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] >='a' && value[i] <= 'z')
                        {
                            str.Append(char.ToUpper(value[i]));


                        }
                        else if (value[i] >= 'A' && value[i] <= 'Z')
                        {
                            str.Append(char.ToLower(value[i]));
                        }
                        else
                        {
                            str.Append(value[i]);
                        }
                    }
                    string lastValue = str.ToString();
                    q.firstQuery = m.Groups[1].Value;
                    q.secondQuery = lastValue;
                    if (broadcasts.ContainsKey("Broadcasts"))
                    {
                        broadcasts["Broadcasts"].Add(q);
                    }
                    else
                    {
                        broadcasts.Add("Broadcasts", new List<Query>());
                        broadcasts["Broadcasts"].Add(q);
                    }

                }



                input = Console.ReadLine();
            }
            int counter = 0;
            foreach (var item in broadcasts)
            {
                Console.WriteLine(item.Key+":");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"{items.secondQuery} -> {items.firstQuery}");
                }
                counter++;
            }
            if (counter == 0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }
            int counter2 = 0;
                 foreach (var item in messages)
            {
                Console.WriteLine(item.Key+":");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"{items.firstQuery} -> {items.secondQuery}");
                }
                counter2++;
            }
            if (counter2 == 0)
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }

        }
    }
    public class Query
    {
        public string firstQuery { get; set; }
        public string secondQuery { get; set; }

    }
}
