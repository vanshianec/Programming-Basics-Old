using System;
using System.Collections.Generic;
using System.Linq;




class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, BankAccount> persons = new Dictionary<int, BankAccount>();

        string[] input = Console.ReadLine().Split(' ').ToArray();
        while(input[0]!="End")
        {
            switch(input[0])
            {
                case "Create":
                    Create(input, persons);
                    break;
                case "Deposit":
                    Deposit(input, persons);
                    break;
                case "Withdraw":
                    Withdraw(input, persons);
                    break;
                case "Print":
                    Print(input, persons);
                    break;




            }

            input = Console.ReadLine().Split(' ').ToArray();
        }




    }

    private static void Create(string[]input, Dictionary<int, BankAccount> persons)
    {
        int id = int.Parse(input[1]);
        if (persons.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount acc = new BankAccount
            {
                Id = id
            };
            persons.Add(id, acc);
        }

    }
    private static void Deposit(string[]input,Dictionary<int, BankAccount> persons)
    {
        int id = int.Parse(input[1]);
        int ammount = int.Parse(input[2]);
        if(!persons.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            persons[id].Balance += ammount;
        }
    }
    private static void Withdraw(string[]input,Dictionary<int, BankAccount > persons)
    {
        int id = int.Parse(input[1]);
        int ammount = int.Parse(input[2]);
        if (!persons.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (ammount > persons[id].Balance)
        {
            Console.WriteLine("Insufficient balance");

        }
        else
        {
            persons[id].Balance -= ammount;

        }


    }
    private static void Print(string[]input,Dictionary<int, BankAccount> persons)
    {
        int id = int.Parse(input[1]);
        if (!persons.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{id}, balance {persons[id].Balance:F2}");
        }

    }
}
