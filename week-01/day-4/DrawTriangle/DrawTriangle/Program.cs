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
            int userNumber = int.Parse(Console.ReadLine());
            string line = "";
            string charForUser = "*";


            for (int i = 0; i <= userNumber; i++)
            {

                line = line + charForUser;
                Console.WriteLine(line);
 
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
