using System;
using System.Collections.Generic;

namespace Pirates
{
    public class Ship
    {
        private List<Pirate> Pirates { get; }

        public Ship()
        {
            Pirates = new List<Pirate>();
        }

        public void FillShip()
        {
            if (IsCaptainPresent() == false)
            {
                Pirates.Add(new Captain());
            }
            Random random = new Random();
            int randomNum = random.Next(1, 114);
            for (int i = 0; i < randomNum; i++)
            {
                Pirates.Add(new Pirate());
            }
        }

        private bool IsCaptainPresent()
        {
            foreach (Pirate pirate in Pirates)
            {
                if (pirate is Captain)
                {
                    return true;
                }
            }
            return false;
        }
    }
}