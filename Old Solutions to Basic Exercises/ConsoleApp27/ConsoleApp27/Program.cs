using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int counter = 0;
            int index = 0;
            while (true)


            {
                index = text.IndexOf("in", index + 1);

                if (index != -1)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);


        }
    }
}
