using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of
            // numbers from zero to the given parameter
            
            Console.WriteLine(sum(6));
        }

        static int sum (int addAll)
        {
            int result = 0;

            for (int i = 0; i <= addAll; i++)
            {
                result = result + i;
            }

            // Use return statement to terminate execution of the method in
            // which it appears and return control to the calling method
            return result;
        }
    }
}
