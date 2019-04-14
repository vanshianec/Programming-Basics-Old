using System;
using System.Collections.Generic;
using System.Text;



    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    public void Deposit(decimal ammount)
    {
        Balance += ammount;
    }
    public void Withdraw(decimal ammount)
    {
        Balance -= ammount;
    }
    public override string ToString()
    {
        return string.Format($"Account {Id}, balance {Balance}");
    }






}

