using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
           string expression = "1 + (3 + 2 - (2+3) * 4 - ((3+1)*(4-2)))";

            Stack<char> commas = new Stack<char>();

            foreach (char ch in expression)
            {
                if (ch == '(')
                {
                    commas.Push(ch);
                }
                else if (ch==')')
                {
                    if(commas.Count==0)
                    {
                        Console.WriteLine("The brackets are not correct");
                        return;
                    }
                    else
                    {
                        commas.Pop();
                    }
                }
            }
            if (commas.Count!=0)
            {
                Console.WriteLine("The brackets are not correct");
            }
            else
            {
                Console.WriteLine("The brackets are correct");
            }


        }
    }
}
