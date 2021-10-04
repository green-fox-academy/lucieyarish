namespace AircraftCarrier
{
    public class F16 : Aircraft
    {
        public F16() : base (AircraftType.F16)
        {
            MaxAmmo = 8;
            BaseDamage = 30;
        }
    }
}