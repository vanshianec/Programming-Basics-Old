using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            if (month.Equals("October") || month.Equals("May"))
            {
                int Studio = 50;
                int Double = 65;
                int Suite = 75;
                double StudioPrice = Studio * nights;
                double DoublePrice = Double * nights;
                double SuitePrice = Suite * nights;
                if (nights > 7 && month.Equals("October"))
                {
                    StudioPrice -= 50;
                }


                else if (nights > 7)
                {
                    StudioPrice = StudioPrice - StudioPrice * 0.05;

                }

                Console.WriteLine($"Studio: {StudioPrice:F2} lv.");
                Console.WriteLine($"Double: {DoublePrice:F2} lv.");
                Console.WriteLine($"Suite: {SuitePrice:F2} lv.");



            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                int Studio = 60;
                int Double = 72;
                int Suite = 82;
                double StudioPrice = Studio * nights;
                double DoublePrice = Double * nights;
                double SuitePrice = Suite * nights;
                if (nights > 7 && month.Equals("September"))
                {
                    StudioPrice -= 60;
                }


                else if (nights > 14)
                {
                    DoublePrice = DoublePrice - DoublePrice * 0.10;

                }

                Console.WriteLine($"Studio: {StudioPrice:F2} lv.");
                Console.WriteLine($"Double: {DoublePrice:F2} lv.");
                Console.WriteLine($"Suite: {SuitePrice:F2} lv.");



            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                int Studio = 68;
                int Double = 77;
                int Suite = 89;
                double StudioPrice = Studio * nights;
                double DoublePrice = Double * nights;
                double SuitePrice = Suite * nights;
               

                 if (nights > 14)
                {
                    SuitePrice = SuitePrice - SuitePrice * 0.15;

                }

                Console.WriteLine($"Studio: {StudioPrice:F2} lv.");
                Console.WriteLine($"Double: {DoublePrice:F2} lv.");
                Console.WriteLine($"Suite: {SuitePrice:F2} lv.");



            }

















        }

    }
}
