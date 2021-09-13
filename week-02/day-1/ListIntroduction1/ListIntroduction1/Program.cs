using System;
using System.Collections.Generic;

namespace ListIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("1. William");
            names.Add("2. John");
            names.Add("3. Amanda");

            //Iterate through the list and print out each name

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Remove the 2nd element
            names.RemoveAt(1);
            //Iterate through the list in a reversed order
            //and print out each name

            names.Reverse();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Console.WriteLine(names);
            
        }
    }
}
