namespace AircraftCarrier
{
    public class F35 : Aircraft
    {
        public F35() : base(AircraftType.F35)
        {
            MaxAmmo = 12;
            BaseDamage = 50;
        }
    }
}