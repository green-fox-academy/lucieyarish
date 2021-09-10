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
            int UserNumber = Int32.Parse(Console.ReadLine());

            string UserChar = "*";
            string EmptyChar = " ";

            for (int i = 1; i <= UserNumber; i++)
            {
                if (UserNumber)
                {
                    Console.Write(UserChar);

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
