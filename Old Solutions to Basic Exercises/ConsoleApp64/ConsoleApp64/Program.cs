using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer("Pesho", 4, 5432, true, true);
            Developer dev2 = new Developer("Gosho", 7, 2311, true, false);
            Developer dev3 = new Developer("Misho", 8, 3141, false, true);
            Developer dev4 = new Developer("Newbie", 1, 1233, false, false);

            Manager man1 = new Manager("Tosho", 6, 6422, 2);
            Manager man2 = new Manager("Penka", 4, 4553, 4);
            Manager man3 = new Manager("Pesho", 12, 9433, 7);

            Developer[] developers = new Developer[4];
            Manager[] managers = new Manager[3];

            developers[0] = dev1;
            developers[1] = dev2;
            developers[2] = dev3;
            developers[3] = dev4;

            managers[0] = man1;
            managers[1] = man2;
            managers[2] = man3;

            double sum = 0;
            for (int i = 0; i < developers.Length; i++)
            {
                sum += developers[i].Salary;
            }
            for (int i = 0; i < managers.Length; i++)
            {
                sum += managers[i].Salary;
            }
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < developers.Length; i++)
            {
                if(developers[i].KnowsCpp==true&&developers[i].KnowsCSharp==true)
                {
                    developers[i].Salary += 500;
                    sum += 500;
                }
                else if (developers[i].KnowsCpp)
                {
                    developers[i].Salary += 100;
                    sum += 100;
                }
                else if (developers[i].KnowsCpp)
                {
                    developers[i].Salary += 500;
                    sum += 100;
                }

            }

            for (int i = 0; i < developers.Length; i++)
            {
                if (developers[i].Internship < 3)
                {
                    sum -= developers[i].Salary;
                    developers[i].Name = "";
                    developers[i].Internship = 0;
                    developers[i].Salary = 0;
                    developers[i].KnowsCpp = false;
                    developers[i].KnowsCSharp = false;
                }
            }
            for (int i = 0; i < managers.Length; i++)
            {
                if (developers[i].Internship < 3)
                {
                    sum -= developers[i].Salary;
                    managers[i].Name = "";
                    managers[i].Internship = 0;
                    managers[i].Salary = 0;
                    managers[i].PeopleManageCount = 0;
                }
            }
            Console.WriteLine("Developers:");
            for (int i = 0; i < developers.Length; i++)
            {
                developers[i].Print();
            }
            Console.WriteLine("Managers:");
            for (int i = 0; i < managers.Length; i++)
            {
                managers[i].Print();
            }
            Console.WriteLine($"Sum: {sum}");






        }
    }
}
