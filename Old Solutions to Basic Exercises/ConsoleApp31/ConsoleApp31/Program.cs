using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            Int32 years = centuries * 100;
            Int32 days = (int)(years * 365.2422);
            Int32 hours = days * 24;
            Int32 minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes ");

        }
    }
}
