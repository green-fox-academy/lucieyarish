using System;
using System.Collections.Generic;
using System.Text;

namespace MapIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> myMap = new Dictionary<string, string>
            {
           
                {"978-1-60309-452-8", "A Letter to Jo"},
                {"978-1-60309-459-7", "Lupus"},
                {"978-1-60309-444-3", "Red Panda and Moon Bear"},
                {"978-1-60309-461-0", "The Lab"},
            };

            foreach (var element in myMap)
            {
                Console.WriteLine(element.Value + " (ISBN: " + element.Key + ")");

            }

            myMap.Remove("978-1-60309-444-3");
            myMap.Remove("978-1-60309-461-0");
            

            myMap.Add("978-1-60309-450-4", "They Called Us Enemy");
            myMap.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            foreach (var item in myMap)
            {
                Console.WriteLine(item.Key + " --- " + item.Value);
            }

            if (myMap.ContainsKey("478-0-61159-424-8") == true)
            {
                Console.WriteLine("Found it!");
            }
            else
            {
                Console.WriteLine("No match!");
            }

            Console.WriteLine(myMap.GetValueOrDefault("978-1-60309-453-5"));

            Console.ReadLine();
        }
    }
}
