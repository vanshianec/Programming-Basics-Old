using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            Subjects subs1 = new Subjects(5, 3, 5, 6, 5, 6, 3, 5);
            Student student1 = new Student("Pesho Ivanov Goshov",0041205067,subs1);
            student1.Print();
            Subjects subs2 = new Subjects(6, 6, 5, 2, 6, 6, 2, 4);
            Student student2 = new Student("Gosho Ivanov Peshov", 991489967, subs2);
            student2.Print();

        }
    }
}
