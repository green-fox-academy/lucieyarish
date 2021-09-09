using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            Console.WriteLine("What is the number of girls coming to the party?");
            string girlsNumInput = Console.ReadLine();
            int girlsNum = Int32.Parse(girlsNumInput);

            Console.WriteLine("What is the number of boys coming to the party?");
            string boysNumInput = Console.ReadLine();
            int boysNum = Int32.Parse(boysNumInput);


            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            if (girlsNum == 0)
            {
                Console.WriteLine("Sausage party!");
            } else if ((girlsNum == boysNum) && (girlsNum + boysNum >= 20))
            {
                Console.WriteLine("The party is excellent!");

                // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
                // it should print: Quite a cool party!
            }
            else if ((girlsNum + boysNum >= 20) && (girlsNum != boysNum))
            {
                Console.WriteLine("Quite a cool party!");

                // If there are less people coming than 20
                // it should print: Average party.

            }
            else if (girlsNum + boysNum < 20)
            {
                Console.WriteLine("Average party.");
                // If no girls are coming, regardless the count of the people
                // it should print: Sausage party
            }
  

        }
    }
}
