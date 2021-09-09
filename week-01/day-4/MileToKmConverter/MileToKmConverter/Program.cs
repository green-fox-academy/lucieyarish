using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            int miles = 2;
            Console.WriteLine("What is " + miles + " multiplied by two?");

            string UserInput = Console.ReadLine();

            // miles * 1.60934;
            double UserInputNum = Int32.Parse(UserInput);

            Console.WriteLine("Nice! That is " + UserInputNum * 1.60934 + " in kilometers!");
        }
    }
}
