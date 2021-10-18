using System;
using System.Linq;

namespace LINQExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            var getSquaredWithLambda = numbers.Where(n => (n * n) > 20).ToList();
            var getSquaredWithQuery = from number in numbers
                where (number * number) > 20
                select number;
        }
    }
}