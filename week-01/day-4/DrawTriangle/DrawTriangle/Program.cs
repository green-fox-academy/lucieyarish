using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            Console.WriteLine("Give me a number, please.");
            string userInput = Console.ReadLine();
            int userNumber = Int32.Parse(userInput);

            string charForUser = "*";

            for (int i = 1; i <= userNumber; i++)
            {
                if ()
                {
                    Console.WriteLine(charForUser + charForUser);

                }
                
            } 

            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
        }
    }
}
