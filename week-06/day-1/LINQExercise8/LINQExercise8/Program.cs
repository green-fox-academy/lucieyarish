using System;
using System.Linq;

namespace LINQExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "OHlala!";
            var findUpperCaseCharsLambda = myString.Where(c => Char.IsUpper(c)).ToList();
            var findUppercaseCharsQuery = from character in myString
                where Char.IsUpper(character)
                select character;
            
            foreach (var item in findUppercaseCharsQuery)
            {
                Console.WriteLine(item);
            }
                
            
        }
    }
}