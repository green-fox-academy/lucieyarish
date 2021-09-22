using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm();
            Animal cow = new Animal();
            Animal pig = new Animal();
            Animal goose = new Animal();
            Animal chicken = new Animal();

            farm.FarmAnimals.Add(cow);
            farm.FarmAnimals.Add(pig);
            farm.FarmAnimals.Add(goose);
            farm.FarmAnimals.Add(chicken);



        }
    }
}
