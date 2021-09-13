using System;
using System.Text;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            StringBuilder sb = new StringBuilder(todoText);

            int index1 = todoText.IndexOf(" ");

            // Add "My todo:" to the beginning of the todoText
            sb.Insert(index1, "My todo:\n");

            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText applying indentation
            sb.Append(" - Download games\n\t- Diablo");

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(sb);
        }
    }
}
