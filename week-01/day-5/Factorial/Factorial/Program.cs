using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create a function called `calculateFactorial()`
            //   that returns the factorial of its input
            Console.WriteLine(calculateFactorial(6));
        }

        static int calculateFactorial(int myNum)
        {
            int result = 1;

            for (int i = 1; i <= myNum; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
