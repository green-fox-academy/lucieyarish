using System;

namespace MaticePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my2DArr = new int[4, 4];
            DiagonalMatrixFromLeftCorner(my2DArr);
            DiagonalMatrixFromRightCorner(my2DArr);
        }

        private static void DiagonalMatrixFromLeftCorner(int[,] myArr)
        {
            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    if (i == j)
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

        public static void DiagonalMatrixFromRightCorner(int [,] myArr)
        {
            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    if (j == (myArr.GetLength(1) - 1 - i))
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