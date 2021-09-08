using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13
            int num1 = 13;
            int num2 = 22;

            double num3 = 13;
            double num4 = 22;

            // Print the result of 13 added to 22
            int sum1 = num1 + num2;

            // Print the result of 13 substracted from 22
            int sum2 = num2 - num1;

            // Print the result of 22 multiplied by 13
            int sum3 = num1 * num2;

            // Print the result of 22 divided by 13 (as a decimal fraction)
            double sum4 = num4 / num3;

            // Print the integer part of 22 divided by 13
            int sum5 = num2 / num1;

            // Print the remainder of 22 divided by 13
            int sum6 = num2 % num1;


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);
            Console.WriteLine(sum5);
            Console.WriteLine(sum6);

        }
    }
}
