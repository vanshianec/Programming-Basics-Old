using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(23);
            stack.Push(2);

            Console.WriteLine(stack.Peak());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peak());
        }
    }
}
