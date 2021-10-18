using System;
using System.IO;
using System.Linq;

namespace LINQExercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "starwars.txt";

            var printHeaviestCharacter =
                File.ReadAllLines(filePath)
                    .OrderByDescending(s => ParsingMethod(s.Split(';')[2]))
                    .Take(1);

            foreach (var item in printHeaviestCharacter)
            {
                Console.WriteLine(item);
            }
        }
        
        public static double ParsingMethod(string s)
        {
            double numVal;
            try
            {
                numVal = Double.Parse(s);
            }
            catch (Exception e)
            {
                numVal = 0;
            }
            return numVal;
        }
    }
}