using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numbers = { 3, 4, 5, 6, 7 };
            


            // - Reverse the order of the elements of `numbers`
            for (int i = numbers.Length - 1; i <= numbers.Length; i--)
            {
                // - Print the elements of the reversed `numbers`
                Console.WriteLine(numbers[i]);
            }

            
        }
    }
}
