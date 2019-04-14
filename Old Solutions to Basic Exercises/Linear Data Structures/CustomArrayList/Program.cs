using System;
using System.Collections.Generic;
namespace CustomArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList shopingList = new CustomArrayList();

            shopingList.Add("Tomato");
            shopingList.Add("Bread");
            shopingList.Add("Cheese");
            shopingList.Add("Cucumbers");
            shopingList.Add("Beer");
            shopingList.Add(7);
            shopingList.Add("Coke");

            for (int i=0;i<shopingList.Count;i++)
            {
                Console.WriteLine(shopingList[i]);
            }
            Console.WriteLine(shopingList.Contains("Beer"));
            
        }
    }
}
