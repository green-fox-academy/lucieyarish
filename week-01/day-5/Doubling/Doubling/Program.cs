using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNumber` and assign the value `123` to it
            int baseNumber = 123;
            PrintDoubleNumber(baseNumber);

            
        }


        // - Create a function called `DoubleNumber()` that doubles it's input parameter
        //   and returns the doubled value
        static void PrintDoubleNumber(int num1)
        {
            // - Print the result of `DoubleNumber(baseNumber)
            Console.WriteLine(num1 * num1);
        }
        
        
    }
}
