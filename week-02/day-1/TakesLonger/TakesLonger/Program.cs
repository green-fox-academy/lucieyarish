using System;
using System.Text;
using System.Collections.Generic;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            StringBuilder sb = new StringBuilder(quote);
            string insertWords = "always takes longer than ";
            int index1 = quote.IndexOf("you"); 
            sb.Insert(index1, insertWords);
            Console.WriteLine(sb);
            
            //StringBuilder sb = new StringBuilder(quote);
            //sb.Insert(21, "always takes longer than");
            //Console.WriteLine(sb);
        }
    }
}
