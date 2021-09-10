using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numbers = { 3, 4, 5, 6, 7 };
            

            // - Double all the values in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int result = numbers[i] * 2;
                Console.WriteLine(result);
            }
                
        }
    }
}
