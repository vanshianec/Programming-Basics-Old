using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] array = new int[fieldSize];
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i == indexes[j])
                    {
                        array[i] = 1;
                        break;
                    }
                }
            }
            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "end")
            {
                int index = int.Parse(command[0]);
                string direction = command[1];
                int newIndex = int.Parse(command[2]);
                int newPosition = 0;
                bool isRight = false;
                bool isLeft = false;
                if (direction == "right")
                {
                    newPosition = index + newIndex;
                    if (newPosition > array.Length - 1||newPosition<0)
                    {
                        if(index>0&&index<array.Length-1)
                        {
                            array[index] = 0;
                        }
                      
                    }
                    else
                    {

                    for (int i = newPosition; i < array.Length; i++)
                    {
                        if (array[i] == 1)
                        {
                            continue;
                        }
                        else
                        {

                            array[i] = 1;
                            array[index] = 0;
                            isRight = true;
                            break;
                        }
                    }
                    if (isRight == false)
                    {
                        array[index] = 0;
                    }
                    }
                }
                else if (direction == "left")
                {
                    newPosition = index - newIndex;
                    if (newPosition < 0||newPosition > array.Length - 1 )
                    {
                        if (index > 0 && index < array.Length - 1)
                        {
                            array[index] = 0;
                        }
                    }
                    else
                    {
                       
                    for (int i = newPosition; i >= 0; i--)
                    {
                        if (array[i] == 1)
                        {
                            continue;
                        }
                        else
                        {
                                array[i] = 1;
                                array[index] = 0;
                                isLeft = true;
                            break;
                        }
                    }
                    if ( isLeft== false)
                    {
                        array[index] = 0;
                    }
                    }
                }

            

                command = Console.ReadLine().Split(' ').ToArray();
            }



            Console.WriteLine(String.Join(" ", array));
            }
     



        
    }
}
