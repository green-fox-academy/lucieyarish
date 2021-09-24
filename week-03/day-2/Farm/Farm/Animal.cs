using System;
using System.Collections.Generic;

namespace Farm
{
    public class Animal
    {
        public int hunger;
        public int thirst;
        public string name;

        public Animal(string name)
        {
            hunger = 50;
            thirst = 50;
            this.name = name;
        }

        public Animal()
        {
        }

        public void Eat()
        {
            hunger--;
            Console.WriteLine($"Hunger level: {hunger}");
        }

        public void Drink()
        {
            thirst--;
            Console.WriteLine($"Thirst level: {thirst}");
        }

        public void Play()
        {
            hunger += 1;
            thirst += 1;
            Console.WriteLine($"Hunger level: {hunger}, Thirst level: {thirst}");
        }
    }
}
