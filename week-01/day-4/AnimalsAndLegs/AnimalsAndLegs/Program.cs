using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            Console.WriteLine("How many chickens does the farmer have?");
            int chickens = int.Parse(Console.ReadLine());

            // The second represents the number of pigs owned by the farmer
            Console.WriteLine("How many pigs does the farmer have?");
            int pigs = int.Parse(Console.ReadLine());

            int chickenLegs = chickens * 2;
            int pigLegs = pigs * 4;
            int legsTotal = chickenLegs + pigLegs;
            // It should print how many legs all the animals have
            Console.WriteLine("The animals have " + legsTotal + " legs altogether.");
        }
    }
}
