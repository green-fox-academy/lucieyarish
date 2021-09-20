using System;
using System.Collections.Generic;
namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void PrintAll()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].Completed == true)
                {
                    Console.WriteLine($"{i + 1}. [x] {Things[i].Name}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {Things[i].Name}");
                }
            }
        }
    }
}
