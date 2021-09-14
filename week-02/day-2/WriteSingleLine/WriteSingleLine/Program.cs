using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message:
            // "Unable to write file: my-file.txt"

            string path = "Assest/my-file.txt";
            WriteLinesFunction(path);
            

            static void WriteLinesFunction (string path)
            {
                try
                {
                    File.WriteAllLines(path, new string[] { "Lucie Yarish" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to write file: my-file.txt");
                }
            }

            Console.ReadLine();

        }
    }
}
