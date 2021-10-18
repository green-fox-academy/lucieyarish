using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>
            {
                new Fox("Waffles", "polar", "yellow"),
                new Fox("Baozi", "polar", "green"),
                new Fox("Julie", "forest", "purple"),
                new Fox("Bob", "pallida", "silver"),
                new Fox("Jerry", "pallida", "green")
            };

            var findGreenFoxes = foxes.Where(f => f.Color == "green");
            var findGreenPallidaFox = foxes.Where(f => f.Color == "green" && f.Type == "pallida").ToList();

            foreach (var item in findGreenPallidaFox)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}