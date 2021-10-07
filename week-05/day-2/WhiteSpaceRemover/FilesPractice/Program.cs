using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

namespace FilesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "input-file.txt";
            WhiteSpaceRemover(path);
        }

        public static void WhiteSpaceRemover(string path)
        {
            try
            {
                string fileContent = File.ReadAllText(path);
                string[] subs = fileContent.Split(" ");

                string output = "";
                foreach (var s in subs)
                {
                    if (s == "")
                    {
                    
                    }
                    else
                    {
                        output += s + " ";
                    }
                }
                Console.WriteLine(output);
            }
            
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File does not exist!");
            }
        }
    }
}