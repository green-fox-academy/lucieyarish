using System;

namespace HeroBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero CaptainAmerica = new Hero("Captain America", 28);
            Hero Batman = new Hero("Batman", 20);
            Batman.Punch(CaptainAmerica);
            CaptainAmerica.GetCurrentMotivationLevel();

        }
    }
}