using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, please!");
            int userNum = Int32.Parse(Console.ReadLine());
            int[,] my2DArr = new int[userNum, userNum];
            
            for (int row = 0; row < userNum; row++)
            {
                for (int column = 0; column < userNum; column++)
                {
                    if (row == column)
                    {
                        Console.Write(1);
                        
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
