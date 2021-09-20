using System;

namespace DiceSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();
            int diceValue = 0;
            diceSet.Roll();

            while(diceValue != 6)
            {
                diceSet.Reroll();
                for (int i = 0; i < 6; i++)
                {
                    if (diceSet.GetCurrent(i) == 6)
                    {
                        diceValue++;
                    }
                }
            }
            Console.WriteLine("All dice are 6!");
        }
    }
}
