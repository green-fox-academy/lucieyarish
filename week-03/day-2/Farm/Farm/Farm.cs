using System;
using System.Collections.Generic;

namespace Farm
{
    public class Farm
    {
        public List<Animal> FarmAnimals { get; set; }
        public int farmCapacity;

        public Farm()
        {
            FarmAnimals = new List<Animal>();
            farmCapacity = 3;
        }


        public void Breed(Animal animal)
        {
            if (FarmAnimals.Count < farmCapacity)
            {
                FarmAnimals.Add(new Animal());
            }
            else
            {
                Console.WriteLine("Sorry, full house! Go somewhere else!");
            }

        }

        public Farm(List<Animal> farmAnimals)
        {
            FarmAnimals = farmAnimals;
        }

        public void Sell()
        {
            for (int i = 0; i < FarmAnimals.Count; i++)
            {
                if (FarmAnimals[i].hunger <= 49)
                {
                    FarmAnimals.RemoveAt(i);
                }
            }
        }
    }
}
