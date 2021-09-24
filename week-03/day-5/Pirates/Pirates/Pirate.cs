using System;

namespace Pirates
{
    public class Pirate
    {
        protected string name;
        protected int intoxicationLevel;
        

        public Pirate(string name)
        {
            this.name = name;
            this.intoxicationLevel = 0;
        }

        public Pirate()
        {
            
        }

        public void DrinkSomeRum()
        {
            intoxicationLevel += 1;
        }

        public void HowsItGoingMate()
        {
            if (intoxicationLevel < 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                intoxicationLevel = 0;
            }
        }
        
        public void Brawl(Pirate other)
        {
            
        }

        public string Get
        {
            get { return (name); }
        }
    }
}