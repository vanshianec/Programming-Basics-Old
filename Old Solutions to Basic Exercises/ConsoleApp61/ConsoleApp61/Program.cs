using System;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
add
developer
Gosho 5 5432 true false
add
developer
Pesho 7 6664 true true
add
developer
Maria 2 2333 false true
add
manager
Tosho 12 4333 3
add
manager
Misho 12 6678 5
add
developer
Maria 5 1534 false false
add
developer
Penka 7 4322 true true
add
manager
Nasko 34 9843 12 
average
end
            */
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
