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
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                
                int temp1 = numbers[0];
                
                numbers[0] = numbers[4];
                numbers[4] = temp1;

                int temp2 = numbers[1];
                numbers[1] = numbers[3];
                numbers[3] = temp2;
                
                Console.WriteLine(numbers[i]);
            }

            // - Print the elements of the reversed `numbers`
        }
    }
}
