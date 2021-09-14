using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "myFile.txt";
            string path2 = "myFile2.txt";
            CopyFile(path1, path2);
        }
        // Write a function that reads all lines of a file and writes
        // the read lines to an other file (a.k.a copies the file)
        // It should take the filenames as parameters
        // It should return a boolean that shows if the copy was successful
        static string CopyFile(string copyFrom, string copyTo)
        { 
            try
            {

                string[] file1 = File.ReadAllLines(copyFrom);
                // take content of file 1 and copy to a new file
                File.WriteAllLines(copyTo, file1);
                
            }
            catch (Exception ex)
            {
	            
            }
            return "";
        }
    }
}
