using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> words = new Dictionary<String, int>();

            String path = @"C:\Users\ivani\Desktop\Нова папка\text.txt";
            StreamReader str = new StreamReader(path);

            String line;

            while ((line = str.ReadLine()) != null)
            {
                List<String> splitedWords = new List<String>();
                Match match = Regex.Match(line, "[A-Za-z]+");
                while (match.Success)
                {
                    splitedWords.Add(match.Groups[0].Value);
                    match = match.NextMatch();
                }
                foreach (var word in splitedWords)
                {
                    if (!words.ContainsKey(word.ToLower()))
                    {
                        words.Add(word.ToLower(), 0);
                    }
                    words[word.ToLower()]++;
                }
            }

            foreach(KeyValuePair<String,int> pair in words.OrderBy(x=> x.Value))
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }

            











        }
    }
}
