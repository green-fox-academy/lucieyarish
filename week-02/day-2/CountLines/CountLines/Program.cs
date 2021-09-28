using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)

        {
            string path = "Assets/myFile.txt";
            LinesCount(path);
        }

        public static void LinesCount(string path)
        {
            try
            {
                string[] content = File.ReadAllLines(path);
                int lines = content.Length;
                Console.WriteLine(lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("0");
            }
        }

    }



}
