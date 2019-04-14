using System;

namespace ConsoleApp163
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 6);
            Point p2 = new Point(6, 12);

            Console.WriteLine($"Distance between the two points: {p1.DistanceBetweenTwoPoints(p2):F2}");
            Console.WriteLine();

            p1.Move(4, 7);
            p1.Print();
            Console.WriteLine();

            p1=p1.Increment();
            p1.Print();
            Console.WriteLine();

            Point p3 = p1 + p2;
            p3.Print();
            Console.WriteLine();

            Point p4 = p1 - p2;
            p4.Print();
            Console.WriteLine();

            Console.WriteLine(p3 > p4);
            Console.WriteLine(p4 > p3);
            Console.WriteLine(p3 == p4);
            Console.WriteLine(p3 != p4);

        }
    }
}
