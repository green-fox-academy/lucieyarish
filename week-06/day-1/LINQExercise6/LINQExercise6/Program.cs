using System;
using System.Linq;

namespace LINQExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "aaabb";

            var findFrequencyOfCharsLambda = myString.ToCharArray().GroupBy(ch => ch).ToDictionary(ch => ch.Key, ch => ch.Count());
            var findFrequencyOfCharsQuery = from character in myString.ToCharArray()
                group character by character
                into characters
                select new { characters.Key, Count = characters.Count()};


            foreach (var item in findFrequencyOfCharsQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}