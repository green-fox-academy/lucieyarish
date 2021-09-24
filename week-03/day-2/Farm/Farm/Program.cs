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


            cow.Eat();
            farm.Breed(new Animal("cow"));
            pig.Eat();
            farm.Breed(new Animal("pig"));
            goose.Eat();
            farm.Breed(new Animal("goose"));
            chicken.Eat();
            farm.Breed(new Animal("chicken"));
        }
    }
}