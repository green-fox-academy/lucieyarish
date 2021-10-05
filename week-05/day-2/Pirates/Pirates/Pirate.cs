using System;

namespace Pirates
{
    public class Pirate
    {
        public string Name { get; protected set; }
        public int IntoxicationLevel { get; protected set; }
        public bool IsAlive { get; protected set; }

        public Pirate(string name)
        {
            Name = name;
            IntoxicationLevel = 0;
        }

        public Pirate()
        {
            
        }

        public void DrinkSomeRum()
        {
            IntoxicationLevel++;
        }

        public void HowsItGoingMate()
        {
            if (IntoxicationLevel < 4)
            {
                Console.WriteLine("Pour me annuder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                IntoxicationLevel = 0;
            }
        }

        public void Brawl(Pirate pirate, Pirate anotherPirate)
        {
            if (pirate.IsAlive == true && anotherPirate.IsAlive == true)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 4);

                if (randomNum == 3)
                {
                    pirate.IsAlive = false;
                    Console.WriteLine($"{pirate} is dead.");
                }
                else
                {
                    anotherPirate.IsAlive = false;
                    Console.WriteLine($"{anotherPirate} is dead.");
                }
            }
        }

        public void Die()
        {
            IsAlive = false;
            Console.WriteLine("He's dead.");
        }
    }
}