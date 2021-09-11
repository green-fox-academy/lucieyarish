using System;

namespace DrawDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:

            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%

            Console.WriteLine("Give me a number, please.");
            int userNum = int.Parse(Console.ReadLine());
            string line = "";
            string charForUser = "%";

            for (int i = 0; i < userNum; i++)
            {
                if (i == userNum || i == 1)
                {
                    Console.Write(charForUser);
                } else
                {

                }
            }


            // The square should have as many lines as the number was
        }
    }
}
