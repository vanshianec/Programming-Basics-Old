using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double cal = (energyContent * 0.01) * volume;
            double sugar = (sugarContent * 0.01) * volume;

            Console.WriteLine($"{volume}ml {name}:\n{cal}kcal, {sugar}g sugars");







        }
    }
}
