using System;
using System.Collections.Generic;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int>{1, 2, 3, 4, 5};
            ContainsSeven(List);
        }

        public static void ContainsSeven(List<int> listName)
        {
            if (listName.Contains(7))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Noooooooo");
            }
        }
    }
}