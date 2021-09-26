using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7 };
            
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            
            //Solution with Array.Reverse
            //Array.Reverse(numbers);
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}     
        }
    }
}
