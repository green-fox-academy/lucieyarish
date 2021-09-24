namespace AircraftCarrier
{
    public abstract class Aircraft
    {
        protected string aircraftType;
        protected int ammunitionAmount;
        protected int ammoStorage;
        protected int baseDamage;
        protected int maxAmmo;

        protected Aircraft(string aircraftType)
        {
            this.aircraftType = aircraftType;
            this.ammunitionAmount = 0;
            this.ammoStorage = 0;
        }

        protected Aircraft()
        {

        }

        public virtual void Fight()
        {
            int damage = baseDamage * ammunitionAmount;
        }

        public virtual void RefillAmmo(int number)
        {
            
        }

        public new virtual string GetType()
        {
            return aircraftType;
        }

        public virtual void GetStatus()
        {
            
        }

        public virtual void IsPriority()
        {
            
        }

    }
}