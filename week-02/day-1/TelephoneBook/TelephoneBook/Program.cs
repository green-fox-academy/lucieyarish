using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> telephoneBook = new Dictionary<string, string>
            {
               {"William A. Lathan", "405-709-1865" },
               {"John K. Miller", "402-247-8568" },
               {"Hortensia E. Foster", "606-481-6467" },
               {"Amanda D. Newland", "319-243-5613" },
               {"Brooke P. Askew", "307-687-2982" },
            };

            Console.WriteLine($"John K. Miller's phone number is: {telephoneBook["John K. Miller"]}");

            string getKey = "";
            foreach (var item in telephoneBook)
            {
                if(item.Value == "307-687-2982")
                {
                    getKey = item.Key;
                }
            }
            Console.WriteLine($"307-687-2982 is {getKey}'s number");

            string getValue = "";
            foreach (var item in telephoneBook)
            {
                if (item.Key == "Chris E. Myers")
                {
                    getValue = item.Value;
                }
            }
            Console.WriteLine("Sorry, I don't know Chris E. Myers' number!");
        }
    }
}
