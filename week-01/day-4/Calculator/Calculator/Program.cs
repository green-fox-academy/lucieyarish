using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            // Get the first number:
            string userInputNum1 = Console.ReadLine();
            int number1 = int.Parse(userInputNum1);

            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            string userInputNum2 = Console.ReadLine();
            int number2 = int.Parse(userInputNum2);

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

            // Get the operation from standard input:
            string operation = Console.ReadLine();
            double result = 0;
            

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
             
            }

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}
