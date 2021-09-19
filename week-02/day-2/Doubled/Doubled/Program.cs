using System;
using System.Text;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "duplicated-chars.txt";
            DecryptFile(path);
            
        }

        static string DecryptFile(string file)
        {

            string path = "duplicated-chars.txt";
            string[] fileContent = File.ReadAllLines(path);
            foreach (var item in fileContent)
            {
                Console.WriteLine(item);
            }

            

            
        }
    }
}
