using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            try
            {
                Console.WriteLine("Please give me a number!");
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException excp)
            {
                Console.WriteLine("Fail!");
            }


        }
    }      
            

           
}