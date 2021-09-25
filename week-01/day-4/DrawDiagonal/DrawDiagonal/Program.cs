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
            string charForUser = "%";

            for (int row = 1; row <= userNum; row++)
            {
                if (row == userNum || row == 1)
                {
                    for (int j = 1; j <= userNum; j++)
                    {
                        Console.Write(charForUser);
                    }
                }
                else
                {
                    Console.Write(charForUser);
                    for (int column = 2; column < userNum; column++)
                    {
                        if (column != row)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(charForUser);
                        }
                    }
                    Console.Write(charForUser);
                }
                Console.Write("\n");
            }   
        }
    }
}
