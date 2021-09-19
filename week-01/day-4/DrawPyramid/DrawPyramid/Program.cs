using System;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number.");
            int userNum = int.Parse(Console.ReadLine());

            int[,] pyramid = new int[userNum, 10];
            int numForUser = 1;

            for (int row = 0; row < pyramid.GetLength(0); row++)
            {
                for (int column = 0; column < pyramid.GetLength(1); column++)
                {
                    Console.WriteLine(pyramid[row,column]);
                }
            }
            Console.WriteLine();
        }
    }
}
