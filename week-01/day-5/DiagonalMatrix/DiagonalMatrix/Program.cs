using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array dynamically with the following content.
            //   Note that a two dimensional array is often called matrix if every
            //   internal array has the same length.
            //   Use a loop!

            int[,] my2DArr = new int[4, 4];
           

            for (int row = 0; row < my2DArr.GetLength(0); row++)
            {
                for (int column = 0; column < my2DArr.GetLength(1); column++)
                {
                    if (row == column)
                    {
                        my2DArr[row, column] = 1;
                        
                    }
                    Console.Write(my2DArr[row, column] + " ");

                }
                Console.WriteLine();
            }    

            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            //   Its length should depend on a variable
            //  
            // - Print this two dimensional array to the output
            
        }
    }
}
