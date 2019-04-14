using System;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string command = Console.ReadLine();
            List<Developer> developers = new List<Developer>();
            List<Manager> managers = new List<Manager>();
            double sum = 0;
            while (command != "end")
            {
                Developer dev = new Developer();
                Manager man = new Manager();

                if (command == "add")
                {
                    string worker = Console.ReadLine();
                    if (worker == "developer")
                    {
                        string[] input = Console.ReadLine().Split(' ').ToArray();
                        dev.Name = input[0];
                        dev.Internship = int.Parse(input[1]);
                        dev.Salary = double.Parse(input[2]);
                        dev.KnowsCSharp = bool.Parse(input[3]);
                        dev.KnowsCpp = bool.Parse(input[4]);
                        developers.Add(dev);
                    }
                    else if (worker == "manager")
                    {
                        string[] input = Console.ReadLine().Split(' ').ToArray();
                        man.Name = input[0];
                        man.Internship = int.Parse(input[1]);
                        man.Salary = double.Parse(input[2]);
                        man.PeopleManageCount = int.Parse(input[3]);
                        managers.Add(man);
                    }
                }
                else if (command == "leave")
                {
                    string worker = Console.ReadLine();
                    if (worker == "developer")
                    {
                        int devIndex = int.Parse(Console.ReadLine());
                        developers.RemoveAt(devIndex);
                    }
                    else if (worker == "manager")
                    {
                        int manIndex = int.Parse(Console.ReadLine());
                        managers.RemoveAt(manIndex);
                    }
                }
                else if (command == "average")
                {
                    foreach (var developer in developers)
                    {
                        sum += developer.Salary;
                    }
                    foreach (var manager in managers)
                    {
                        sum += manager.Salary;
                    }
                    Console.WriteLine("Monthly Expenditure:");
                    Console.WriteLine($"{sum:F2} lv.");

                }
                else if (command == "print")
                {
                    Console.WriteLine("Developers:");
                    Console.WriteLine($"#NAME#  #INTERNSHIP#  #SALARY#  #KNOWSCSHRAP#  #KNOWSCPP#");
                    foreach (var developer in developers)
                    {

                        Console.WriteLine($"{developer.Name}        {developer.Internship}         {developer.Salary}        {developer.KnowsCSharp}         {developer.KnowsCpp}");

                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Managers:");
                    Console.WriteLine($"#NAME#  #INTERNSHIP#  #SALARY#  #PEOPLE_MANAGE_COUNT#");
                    foreach (var manager in managers)
                    {
                        Console.WriteLine($"{manager.Name}        {manager.Internship}         {manager.Salary}              {manager.PeopleManageCount}");

                    }

                }
                command = Console.ReadLine();

            }
            if(sum==0)
            {
                foreach (var developer in developers)
                {
                    sum += developer.Salary;
                }
                foreach (var manager in managers)
                {
                    sum += manager.Salary;
                }
            }
            int devCounter = 0;
            Console.WriteLine("All developers :");
            Console.WriteLine($"#NAME#  #INTERNSHIP#  #SALARY#  #KNOWSCSHRAP#  #KNOWSCPP#");

            foreach (var developer in developers.Where(x=> x.Internship>=3))
            {

                
                if (developer.KnowsCSharp == true && developer.KnowsCpp == true)
                {
                    developer.Salary += 500;
                    sum += 500;
                }
                else if (developer.KnowsCpp == true)
                {
                    developer.Salary += 500;
                    sum += 500;
                }
                else if (developer.KnowsCSharp == true)
                {
                    developer.Salary += 100;
                    sum += 100;
                }
                Console.WriteLine($"{developer.Name}        {developer.Internship}         {developer.Salary}        {developer.KnowsCSharp}         {developer.KnowsCpp}");

               
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("All managers : ");
            Console.WriteLine($"#NAME#  #INTERNSHIP#  #SALARY#  #PEOPLE_MANAGE_COUNT#");
            foreach (var manager in managers.Where(x=> x.Internship>=3))
            {
               

                Console.WriteLine($"{manager.Name}        {manager.Internship}         {manager.Salary}              {manager.PeopleManageCount}");

               
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Monthly Expenditure:");
            Console.WriteLine($"{sum:F2} lv.");

        }
    }
}
