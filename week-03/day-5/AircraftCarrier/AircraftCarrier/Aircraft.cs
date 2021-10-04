using System.IO.MemoryMappedFiles;

namespace AircraftCarrier
{
    public abstract class Aircraft
    {
        public int AmmoAmount { get; protected set; }
        public int BaseDamage { get; protected set; }
        public int MaxAmmo { get; protected set; }
        public int Damage { get; protected set; }
        private AircraftType Type;
        public Aircraft(AircraftType type)
        {
            Type = type;
            AmmoAmount = 0;
        }

        public int Fight()
        {
            int Damage = BaseDamage * AmmoAmount;
            AmmoAmount = 0;
            return Damage;
        }

        public int RefillAmmo(int ammoRefill)
        {
            int freeCapacity = MaxAmmo - AmmoAmount;
            return ammoRefill - freeCapacity;
        }

        public string GetType()
        {
            return Type.ToString();
        }

        public string GetStatus()
        {
            return $"Type: {Type}, Ammo: {AmmoAmount}, Base Damage: {BaseDamage}, All Damage: {Damage}";
        }

        public bool IsPriority()
        {
            if (Type == AircraftType.F35)
            {
                return true;
            }
            return false;
        }
    }
}