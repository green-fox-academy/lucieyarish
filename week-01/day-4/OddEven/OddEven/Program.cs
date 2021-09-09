using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)

        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("Give me a random number, please.");
            string randomNumber = Console.ReadLine();

            int userInput = Int32.Parse(randomNumber);

            if (userInput % 2 == 0)
            {
                Console.WriteLine("This is an even number!");
            } else
            {
                Console.WriteLine("This is an odd number!");
            }



            

            
        }
    }
}
