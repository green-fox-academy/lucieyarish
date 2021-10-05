using System;

namespace AnimalsInTheZoo
{
    public class Reptile : Animal
    {
        public string Name { get; set; }
        
        public Reptile(string name)
        {
            Name = name;
        }
        
        public string GetName()
        {
            return Name;
        }

        public override void WantChild()
        {
            Console.WriteLine("wants a child from an egg");
        }
    }
}