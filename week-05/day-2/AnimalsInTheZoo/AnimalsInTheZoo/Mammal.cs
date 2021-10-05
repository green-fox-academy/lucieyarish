using System;

namespace AnimalsInTheZoo
{
    public class Mammal : Animal
    {
        public string Name { get; set; }
        
        public Mammal(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public override void WantChild()
        {
            Console.WriteLine("doesn't want a child from an egg");
        }
    }
}