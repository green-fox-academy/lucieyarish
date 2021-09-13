using System;
using System.Collections.Generic;

namespace MapIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> myMap = new Dictionary <int, char> {
                {97,'a'},
                {98,'b'},
                {99,'c'},
                {65,'A'},
                {66,'B'},
                {67,'C'},
            };

            //Print all the keys
            foreach (var element in myMap)
            {
                Console.WriteLine(element.Key);
            }

            //Print all the values
            foreach (var element in myMap)
            {
                Console.WriteLine(element.Value);
            }

            //Add value D with the key 68
            myMap.Add(68, 'D');

            //Print how many key-value pairs are in the map
            Console.WriteLine(myMap.Count);
        }
    }
}
