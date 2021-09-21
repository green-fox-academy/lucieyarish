using System;
using System.Collections.Generic;

namespace Farm
{
    public class Animal
    {
        public int Hunger = 50;
        private int Thirst = 50;

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
