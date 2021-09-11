using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Please give me a number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me one more number, please.");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            } else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
