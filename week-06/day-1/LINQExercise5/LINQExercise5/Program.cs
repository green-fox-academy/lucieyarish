using System;
using System.Linq;

namespace LINQExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var getValueFrequencyWithLambda = numbers.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            var getValueFrequencyWithQuery = from number in numbers
                group number by number
                into g
                select new {g.Key, Count = g.Count()};

            foreach (var number in getValueFrequencyWithLambda)
            {
                Console.WriteLine(number);
            }
        }
    }
}