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
            string fileContent = File.ReadAllText(path);
            // string result = fileContent.Replace(' ', '|');
            string[] subs = fileContent.Split(" ");
            // char[] toChar = fileContent.ToCharArray();
            
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
            // foreach (string s in subs)
            // {
            //     // string str = string.Join("", subs);
            //     if (s != "")
            //     {
            //         output = String.Join(" ", s);
            //     }
            // }
            
            

            Console.WriteLine(output);


            // for (int i = 0; i < toChar.Length; i++)
            // {
            //     if (toChar[i].ToString() == "")
            //     {
            //         Console.WriteLine(toChar[i].ToString());
            //     }
            // }




            // try
            // {
            //     
            //
            // }
            // catch (FileNotFoundException)
            // {
            //     throw new FileNotFoundException("File does not exist!");
            // }
        }
    }
}