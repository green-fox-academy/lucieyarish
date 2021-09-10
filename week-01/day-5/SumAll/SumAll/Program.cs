using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numbers = new int [] { 3, 4, 5, 6, 7 };
            int sum = 0;

            // - Print the sum of the elements of `numbers`

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i]; 

            }
            Console.WriteLine(sum);
        }
    }
}
