using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> beehievs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> aliveBees = new List<int>();
            int counter = 0;
            int maxCounter = beehievs.Count;
            for (int i = 0; i < beehievs.Count; i++)
            {
                if (counter == maxCounter)
                {
                    break;
                }
                int hornetsPower = hornets.Sum(x => x);
                if (beehievs[i] < hornetsPower)
                {
                    beehievs.RemoveAt(i);
                    i--;


                }
                else
                {
                    hornets.RemoveAt(0);
                    beehievs[i] = Math.Abs(hornetsPower - beehievs[i]);
                    if (beehievs[i] <= 0)
                    {

                    }
                    else
                {
                    aliveBees.Add(beehievs[i]);

                }
                }
                counter++;


            }
            if (aliveBees.Count > 0)
            {
                Console.WriteLine(String.Join(" ", aliveBees));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }





        }
    }
}
