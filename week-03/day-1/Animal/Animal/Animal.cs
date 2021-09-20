using System;
namespace Animal
{
    public class Animal
    {
        private int Hunger = 50;
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

            Hunger+= 1;
            Thirst+= 1;
            Console.WriteLine($"Hunger level: {Hunger}, Thirst level: {Thirst}");
        }
    }
}
