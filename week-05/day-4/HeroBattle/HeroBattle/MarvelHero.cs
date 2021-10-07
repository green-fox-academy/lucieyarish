namespace HeroBattle
{
    public class MarvelHero : Hero
    {
        public MarvelHero(string name, double motivationLevel) : base(name, motivationLevel)
        {
            IsMarvelHero = true;
        }
        
        public MarvelHero(string name) : base(name, 40)
        {
            IsMarvelHero = true;
        }
    }
}