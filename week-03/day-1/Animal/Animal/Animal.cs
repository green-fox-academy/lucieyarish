using System;
namespace Animal
{
    public class Animal
    {
        private int Hunger;
        private int Thirst;

        public Animal(int hunger, int thirst)
        {
            Hunger = hunger;
            Thirst = thirst;
        }

        public void Eat()
        {
            Hunger--;
            Console.WriteLine(Hunger);
        }

        public void Drink()
        {
            Thirst--;
            Console.WriteLine(Thirst);
        }

        public void Play()
        {

            Hunger+= 1;
            Thirst+= 1;
            Console.WriteLine(Hunger + " and " + Thirst);
        }
    }
}
