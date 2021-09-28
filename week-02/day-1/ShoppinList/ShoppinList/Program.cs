using System;
using System.Collections.Generic;

namespace ShoppinList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>{"eggs", "milk", "fish", "apples", "bread", "chicken"};
            DoWeHaveMilk(shoppingList);
            DoWeHaveBananas(shoppingList);
        }
        
        private static void DoWeHaveMilk(List<string> shoppingList)
        {
            if (shoppingList.Contains("milk"))
            {
                Console.WriteLine("We do have milk!");
            }
            else
            {
                Console.WriteLine("No milk!");
            }
        }
        
        private static void DoWeHaveBananas(List<string> shoppingList)
        {
            if (shoppingList.Contains("bananas"))
            {
                Console.WriteLine("We do have bananas!");
            }
            else
            {
                Console.WriteLine("No bananas!");
            }
        }
    }
}