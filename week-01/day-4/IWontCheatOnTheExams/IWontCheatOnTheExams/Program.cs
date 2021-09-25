using System;

namespace IWontCheatOnTheExams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            //Solution 1 with while loop:

            //int a = 0;
            //while (a <= 100)
            //{
            //    Console.WriteLine("I won't cheat on the exam!");
            //    a++;
            //}

            // Solution 2 with for loop:
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I won't cheat on the exam!");
            }
        }
    }
}
