using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("Give me a random number, please!");
            string randomNumber = Console.ReadLine();

            int userNumber = Int32.Parse(randomNumber);

            if (userNumber <= 0)
            {
                Console.WriteLine("Not enough!");

            } else if (userNumber == 1)
            {
                Console.WriteLine("One");

            } else if (userNumber == 2)
            {
                Console.WriteLine("Two");
            } else
            {
                Console.WriteLine("A lot");
            }

        }
    }
}
