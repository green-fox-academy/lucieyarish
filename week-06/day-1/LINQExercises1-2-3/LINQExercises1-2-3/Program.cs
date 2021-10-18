using System;
using System.Linq;

namespace LINQExercises1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var getEvenWithLambda = numbers.Where(n => n % 2 == 0).ToList();
            var getEvenWithQuery = from number in numbers
                where number % 2 == 0
                select number;

            var getAvgWithLambda = numbers.Where(n => n % 2 != 0).Average();
            var getAvgWithQuery = (from number in numbers
                where number % 2 != 0
                select number).Average();

            var getSquareOfPositiveWithLambda = numbers.Where(n => n >= 0).Select(n => n * n);
            var getSquareOfPositiveWithQuery = from number in numbers
                where number >= 0
                select number * number;
        }
    }
}