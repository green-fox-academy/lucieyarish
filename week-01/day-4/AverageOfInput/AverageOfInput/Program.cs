using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            Console.WriteLine("Give me one integer, please.");
            int givenInt1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me one more, please.");
            int givenInt2 = int.Parse(Console.ReadLine());

            Console.WriteLine("And one more integer, please.");
            int givenInt3 = int.Parse(Console.ReadLine());

            Console.WriteLine("I still need one more.");
            int givenInt4 = int.Parse(Console.ReadLine());

            Console.WriteLine("And one last integer, please!");
            int givenInt5 = int.Parse(Console.ReadLine());

            int sum = givenInt1 + givenInt2 + givenInt3 + givenInt4 + givenInt5;
            int average = sum / 5;
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4


            Console.WriteLine("Sum: " + sum + ", Average: " + average);
        }
    }
}
