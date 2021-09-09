using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            Console.WriteLine("Give me a number please.");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number please.");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num2 > num1)
            {
                for (; num1 < num2; num1++)
                {
                    Console.WriteLine(num1);
                }
            }
            else
            {
                Console.WriteLine("The second number should be bigger.");
            }

            
                // If the second number is not bigger than the first one it should print:
                // "The second number should be bigger"
               


                // If it is bigger it should count from the first number to the second by one
                //
                // example:

            
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}
