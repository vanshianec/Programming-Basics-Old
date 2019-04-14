using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>(5);
            for (int i=0;i<5;i++)
            {
                myQueue.Enqueue(i);
            }
            myQueue.Dequeue();
            myQueue.Dequeue();
            int[]array=myQueue.ToArray();
            Console.WriteLine(String.Join(", ", array));
             

             



        }
    }
}
