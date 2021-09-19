using System;
using System.Collections.Generic;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myPersonalFinance = new List<int>();
            myPersonalFinance.AddRange(new int[] { 500, 1000, 1250, 175, 800, 120 });

            int sum = 0;
            foreach (var item in myPersonalFinance)
            {
                sum += item;
            }

            Console.WriteLine($"You've spent {sum} in total.");

            int greatestExpense = 0;
            foreach (int item in myPersonalFinance)
            {
                if (greatestExpense < item)
                {
                    greatestExpense = item;
                }
            }

            Console.WriteLine($"The greatest expense was: { greatestExpense}.");

            int lowestExpense = 0;
            foreach (int item in myPersonalFinance)
            {
                if (lowestExpense < item)
                {
                    lowestExpense = item;
                }
            }

            Console.WriteLine($"The lowest expense was: { lowestExpense}.");

            int averageSpent = 0;
            foreach (int item in myPersonalFinance)
            {
                averageSpent += item;
            }

            averageSpent = averageSpent / myPersonalFinance.Count;

            Console.WriteLine($"The average amount of your spendings: { averageSpent }.");
        }
    }
}
