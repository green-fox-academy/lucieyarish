using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/lucieyarish/greenfox/lucieyarish/week-02/day-2/WriteMultipleLines/WriteMultipleLines/Assets/myfile.txt";
            WriteMultipleLines(path, "pear", 3);

            static void WriteMultipleLines(string path, string word, int line)
            {
                try
                {
                    for (int i = 0; i < line; i++)
                    {
                        File.AppendAllText(path, word + "\n");
                         
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }
    }
}
