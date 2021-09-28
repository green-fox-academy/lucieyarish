using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/lucieyarish/greenfox/lucieyarish/week-02/day-2/PrintEachLine/PrintEachLine/Assets/myfile.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                foreach (string line in content)
                {
                    Console.WriteLine(line);
                }
            }
            catch
            {
                    Console.WriteLine("Unable to read file: my-file.txt");
            }
        }   
    }
}
