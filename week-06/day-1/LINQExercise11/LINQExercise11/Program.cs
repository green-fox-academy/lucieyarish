using System;
using System.IO;
using System.Linq;

namespace LINQExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "article.txt";

            var get100mostCommonWords = 
                File.ReadAllText(filePath)
                    .Split(" ")
                    .GroupBy(word => word)
                    .ToDictionary(w => w.Key, w => w.Count())
                    .OrderByDescending(item => item.Value)
                    .ThenBy(item => item.Key)
                    .Take(100);

            foreach (var item in get100mostCommonWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}