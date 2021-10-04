using System;
using System.Collections.Generic;

namespace AircraftCarrier
{
    public class Carrier
    {
        private List<Aircraft> Aircrafts { get; }
        protected int InitialAmmo { get; set; }
        public int HealthPoint { get; set; }

        public Carrier(int initialAmmo, int healthPoint)
        {
            Aircrafts = new List<Aircraft>();
            InitialAmmo = initialAmmo;
            HealthPoint = healthPoint;
        }

        public void Add(Aircraft aircraft)
        {
            Aircrafts.Add(aircraft);
        }

        public void Fill()
        {
            try
            {
                foreach (var aircraft in Aircrafts)
                {
                    if (InitialAmmo < 20 && aircraft.IsPriority())
                    {
                        aircraft.RefillAmmo(InitialAmmo);
                    }
                    else
                    {
                        aircraft.RefillAmmo(InitialAmmo / Aircrafts.Count);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void Fight(Carrier anotherCarrier)
        {
            foreach (var aircraft in Aircrafts)
            {
                aircraft.Fight();
            }
            anotherCarrier.HealthPoint = 0;
        }

        public string GetStatus()
        {
            if (HealthPoint == 0)
            {
                Console.WriteLine("It's dead Jim :(");
            }
            
            int totalDamage = 0;
            foreach (var aircraft in Aircrafts)
            {
                totalDamage += aircraft.Damage;
            }
            return $"HP: {HealthPoint}, Aircraft count: {Aircrafts.Count}, Ammo Storage {InitialAmmo}, Total damage: {totalDamage}";
        }
    }
}