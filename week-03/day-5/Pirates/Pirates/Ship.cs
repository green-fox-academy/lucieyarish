using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Pirates
{
    public class Ship
    {
        protected List<Pirate> Pirates;
        protected string ShipName;
        protected int crewAmount;
        protected int captain;

        public Ship()
        {
            Pirates = new List<Pirate>();
            this.crewAmount = 0;
            this.captain = 0;
        }

        public void AddPirate(Pirate pirate)
        {
            Pirates.Add(pirate);
        }

        public void FillShip()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 114);
            for (int i = 0; i < randomNum; i++)
            {
                Pirates.Add(new Pirate());
            }
        }

        public void PrintAll()
        {
            foreach (var item in Pirates)
            {
                Console.WriteLine($"{item.Get}");
            }
        }   
    }
}