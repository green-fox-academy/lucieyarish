using System;
using System.Collections.Generic;
namespace Farm
{
    public class Farm
    {
        List<Animal> FarmAnimals;
        public int FarmCapacity = 3;

        public Farm()
        {
            FarmAnimals = new List<Animal>();
            int farmCapacity = 3;
        }

        public void AddAnimal(Animal animal)
        {

            FarmAnimals.Add(animal);
        }

        public int Breed()
        {
            int count = 0;
            for (int i = 0; i < FarmAnimals.Count; i++)
            {
                if (FarmAnimals.Count <= FarmCapacity)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Sorry, the farm capacity is full!");
                }
            }
            return count;
        }

        public void Sell()
        {
            for (int i = 0; i < FarmAnimals.Count; i++)
            {
                if (FarmAnimals[i].Hunger <= 49)
                {
                    FarmAnimals.RemoveAt(i);
                }
            }
        }
    }
}
