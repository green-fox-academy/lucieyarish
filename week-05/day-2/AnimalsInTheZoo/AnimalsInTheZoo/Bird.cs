using System;

namespace AnimalsInTheZoo
{
    public class Bird : Animal
    {
        public string Name { get; set; }
        
        public Bird(string name)
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