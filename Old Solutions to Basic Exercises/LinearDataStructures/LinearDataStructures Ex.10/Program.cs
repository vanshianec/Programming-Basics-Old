using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._10
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            
            // S1 = N;
            // S2 = S1 + 1;
            // S3 = 2 * S1 + 1;
            // S4 = S1 + 2;
            // S5 = S2 + 1;
            // S6 = 2 * S2 + 1;
            // S7 = S2 + 2;
            //...
            


            Queue<int> queue = new Queue<int>();
            int N = int.Parse(Console.ReadLine());
            queue.Enqueue(N);
            int index = 0;
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(current + "  ");
                if (index == 50)
                {
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(current * 2 + 1);
                queue.Enqueue(current + 2);
            }
        


        }
    }
}
