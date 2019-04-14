using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            //wing flaps
            long N = long.Parse(Console.ReadLine());
            //distance for 1000 wing flaps
            double M = double.Parse(Console.ReadLine());
            //endurance before 5 sec rest
            long P = long.Parse(Console.ReadLine());

            double distance = (N / 1000) * M;
            long flapsSeconds = N / 100;
            long rest = N / P * 5;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{flapsSeconds + rest} s.");




        }



    }
}


    

