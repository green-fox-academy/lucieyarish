using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String which is passed as the parameter
            // Pass the toBeReversed variable to this method to check if it works well

            Console.WriteLine(Reverse(toBeReversed));
        }

        static string Reverse(string s)
        {
            char[] test = s.ToCharArray();
            Array.Reverse(test);
            return new string (test);
        }
    }
}
