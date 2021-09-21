using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm allFarmAnimals = new Farm();
            Animal cow = new Animal();
            Animal pig = new Animal();
            allFarmAnimals.AddAnimal(cow);
            allFarmAnimals.AddAnimal(pig);
            pig.Eat();

            Console.WriteLine(allFarmAnimals.Breed());
        }
    }
}
