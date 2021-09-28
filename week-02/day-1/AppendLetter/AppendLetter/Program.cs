using System;
using System.Collections.Generic;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string> {"koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"};
            AppendA(animals);
        }

        public static void AppendA(List<string> listName)
        {
            foreach (string item in listName)
            {
                Console.WriteLine(item + "a");
            }
        }
    }
}