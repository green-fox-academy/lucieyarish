using System;
using System.Collections.Generic;
namespace FleetOfThings2
{
    public class Fleet
    {
        private List<Things> Things;

        public Fleet()
        {
            Things = new List<Things>();
        }

        public void Add(Things thing)
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
