using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char maxValue = ' ';
            char minValue = ' ';
            if (first > second)
            {
                maxValue = first;
            }
            else if (second > first)
            {
                maxValue = second;
            }
            else
            {
                maxValue = first;
            }
            if (first < second)
            {
                minValue = first;
            }
            else if (second < first)
            {
                minValue = second;
            }
            else
            {
                minValue = first;
            }



            for (char a = minValue; a<=maxValue;a++)
            {
                for(char b = minValue; b<=maxValue;b++)
                {
                    for (char c = minValue; c <=maxValue; c++)
                    {
                        if (a == third || b == third || c == third)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                        
                    }
                        
                }
            }

        }
    }
}
