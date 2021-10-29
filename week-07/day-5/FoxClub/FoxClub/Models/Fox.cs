using System.Collections.Generic;
using System.IO;

namespace FoxClub
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }

        public Fox(string name)
        {
            Name = name;
            Food = "donut";
            Drink = "milk";
        }
    }
}