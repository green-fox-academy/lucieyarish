﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number

            Console.WriteLine("Please give me a number that you want to multiply.");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150

            for (int i = 0; i <= 10; i++)
            {
                int result = i * userNumber;
                Console.WriteLine(i + " * " + userNumber + " = " + result);

            }

        }
    }
}
