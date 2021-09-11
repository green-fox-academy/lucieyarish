using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number and the user has to figure it out
            int num = 8;
            // The user can input guesses
            Console.WriteLine("Try to guess the correct number!");
            int userGuess = int.Parse(Console.ReadLine());


            // After each guess the program would tell one of the following:
            do
            {
                if (userGuess < num)
                {
                    Console.WriteLine("The stored number is higher!");
                }
                if (userGuess > num)
                {
                    Console.WriteLine("The stored number is lower!");
                }
                if (userGuess == num)
                {
                    Console.WriteLine("You found the number!");
                }
                Console.WriteLine("Try to guess the correct number!");
                userGuess = int.Parse(Console.ReadLine());

            } while (userGuess != 8);

            
            
            // The stored number is higher
            // The stored number is lower
            // You found the number: 8


        }
    }
}
