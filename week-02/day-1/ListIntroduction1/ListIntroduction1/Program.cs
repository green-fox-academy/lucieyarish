using System;
using System.Collections.Generic;

namespace ListIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("William");
            names.Add("John");
            names.Add("Amanda");

            //Iterate through the list and print out each name

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Iterate through the list and print
            int order = 0;
            foreach (var name in names)
            {
                order += 1;
                Console.WriteLine(order + ". " + name);
            }


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

            //Remove all elements
            names.Clear();
            Console.WriteLine(names.Count);

        }
    }
}
