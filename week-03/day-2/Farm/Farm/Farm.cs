using System;
using System.Collections.Generic;

namespace Farm
{
    public class Farm
    {
        public List<Animal> FarmAnimals { get; public set; }
        public int farmCapacity;

        public Farm()
        {
            FarmAnimals = new List<Animal>();
            farmCapacity = 3;
        }
    

        public void Breed()
        {
            if (FarmAnimals.Count < farmCapacity)
             {
                FarmAnimals.Add(new Animal());
             }
    
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
