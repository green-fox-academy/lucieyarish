﻿using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            int[] numbers = { 1, 2, 3, 8, 5, 6 };
            // - Change the value of the fourth element (8) to 4
            numbers[3] = 4;
            // - Print the fourth element
            Console.WriteLine(numbers[3]);
        }
    }
}
