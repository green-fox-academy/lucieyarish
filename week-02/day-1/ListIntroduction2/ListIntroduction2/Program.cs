using System;
using System.Collections.Generic;

namespace ListIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listA = new List<string>();
            listA.AddRange(new string[] { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" });
            List<string> listB = new List<string>();
            listB.AddRange(listA);
            Console.WriteLine(listA.Contains("Durian"));
            listB.RemoveAt(3);
            listA.Insert(5, "Kiwifruit");
            if (listA.Count == listB.Count)
            {
                Console.WriteLine("Same!"); 
            } else
            {
                Console.WriteLine("Not the same!");
            }
            Console.WriteLine(listA.IndexOf("Avocado"));
            Console.WriteLine(listB.IndexOf("Durian"));

            listB.AddRange(new string[] { "Passion Fruit", "Pomelo" });
            Console.WriteLine(listA[2]);

            Console.ReadLine();

        }
    }
}
