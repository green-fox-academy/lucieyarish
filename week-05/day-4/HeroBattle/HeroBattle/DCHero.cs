namespace HeroBattle
{
    public class DCHero : Hero
    {
        public DCHero(string name, double motivationLevel) : base(name, motivationLevel)
        {
            IsDCHero = true;
        }

        public DCHero(string name) : base(name, 45)
        {
            IsDCHero = true;
        }
    }
}