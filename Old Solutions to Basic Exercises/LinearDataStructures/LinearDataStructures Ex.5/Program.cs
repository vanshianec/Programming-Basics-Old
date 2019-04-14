using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures_Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //REMOVE ALL NEGATIVE NUMBERS FROM A LIST

            List<int> positiveNumbers = Console.ReadLine().Split(' ').Select(
                int.Parse).Where(x=>x>=0).ToList();

            Console.WriteLine(String.Join(", ", positiveNumbers));



        }
    }
}
