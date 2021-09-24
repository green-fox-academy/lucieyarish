using System;
using System.Collections.Generic;

namespace Farm
{
    public class Animal
    {
        public Animal(int hunger, int thirst, string name)
        {
            Hunger = hunger;
            Thirst = thirst;
            Name = name;
        }

        public int Hunger;
        public int Thirst;
        public string Name;

        public Animal(string name)
        {
            Hunger = 50;
            Thirst = 50;
            this.Name = name;
        }

        public Animal()
        {
        }

        public void Eat()
        {
            Hunger--;
            Console.WriteLine($"Hunger level: {Hunger}");
        }

        public void Drink()
        {
            Thirst--;
            Console.WriteLine($"Thirst level: {Thirst}");
        }

        public void Play()
        {
            Hunger += 1;
            Thirst += 1;
            Console.WriteLine($"Hunger level: {Hunger}, Thirst level: {Thirst}");
        }
    }
}
