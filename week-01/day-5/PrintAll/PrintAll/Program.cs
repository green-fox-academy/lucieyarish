﻿using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            int[] numbers = { 4, 5, 6, 7 };
            // - Print all the elements of `numbers`
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "");
            }
        }
    }
}
