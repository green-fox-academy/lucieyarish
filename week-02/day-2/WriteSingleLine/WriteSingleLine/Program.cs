using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your name, please!");
            string userName = Console.ReadLine();
            WriteLine(userName);
        }
        public static void WriteLine(string name)
        {
            string path = "/Users/lucieyarish/greenfox/lucieyarish/week-02/day-2/WriteSingleLine/WriteSingleLine/Assets/my-file.txt";
            try
            {
                File.WriteAllText(path, name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}
