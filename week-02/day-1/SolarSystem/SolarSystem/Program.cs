using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn");
            
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
    }
}