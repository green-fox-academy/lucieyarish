using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            int[] firstArrayOfNumbers = { 1, 2, 3 };

            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`

            int[] secondArrayOfNumbers = {4, 5};
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`
            // - Otherwise print: "firstArrayOfNumbers is the longer one"

            if (firstArrayOfNumbers.Length > secondArrayOfNumbers.Length)
            {
                Console.WriteLine("firstArrayOfNumbers is the longer one");
            } else
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            }

            Console.ReadLine();
        }
    }
}
