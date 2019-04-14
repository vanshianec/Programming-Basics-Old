using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "end")

            {
                if (command[0] == "reverse")
                {
                    bool isInside = false;
                    int start = int.Parse(command[2]);
                    int counter = int.Parse(command[4]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (start == i)
                        {
                            isInside = true;
                            break;
                        }
                    }
                    if (counter < 0 || isInside == false)
                    {
                        Console.WriteLine("Invalid input parameters");
                    }
                    else
                    {
                        int length = 0;
                        for (int i = 0; i < start; i++)
                        {
                            length++;
                        }
                        length += counter;
                        List<string> copy = new List<string>();
                        for (int i = length - 1; i >= start; i--)
                        {
                            copy.Add(list[i]);
                        }
                        list.RemoveRange(start, counter);
                        list.InsertRange(start, copy);

                    }

                }
                else if (command[0] == "sort")
                {
                    bool isInside = false;
                    int start = int.Parse(command[2]);
                    int counter = int.Parse(command[4]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (start == i)
                        {
                            isInside = true;
                            break;
                        }
                    }
                    if (counter < 0 || isInside == false)
                    {
                        Console.WriteLine("Invalid input parameters");
                    }
                    else
                    {
                        int length = 0;
                        for (int i = 0; i < start; i++)
                        {
                            length++;
                        }
                        length += counter;
                        List<string> copy = new List<string>();
                        for (int i = length - 1; i >= start; i--)
                        {
                            copy.Add(list[i]);
                        }
                        copy.Sort();
                        list.RemoveRange(start, counter);
                        list.InsertRange(start, copy);
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();



            }
            Console.WriteLine(String.Join(" ", list));





        }
    }
}
