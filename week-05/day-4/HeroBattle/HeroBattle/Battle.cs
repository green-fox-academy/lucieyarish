using System;
using System.Collections.Generic;

namespace HeroBattle
{
    public class Battle
    {
        public List<Hero> Heroes { get; protected set; }

        public Battle(List<Hero> heroes)
        {
            Heroes = new List<Hero>();
            Heroes = heroes;
        }

        public List<Hero> AvengersAssemble()
        {
            List<Hero> MostMotivatedMarvels = new List<Hero>();
            foreach (var hero in Heroes)
            {
                if (hero is MarvelHero && hero.GetMotivationLevel() == 2)
                {
                    MostMotivatedMarvels.Add(hero);
                }
            }
            return MostMotivatedMarvels;
        }

        public void StartBattle()
        {
            AvengersAssemble();
            foreach (var hero in AvengersAssemble())
            {
                Console.WriteLine($"Attacker team: {hero}");
            }

            List<Hero> DCHeroes = new List<Hero>();
            foreach (var hero in Heroes)
            {
                if (hero is DCHero)
                {
                    DCHeroes.Add(hero);
                    Console.WriteLine(hero);
                }
            }
        }
        
    }
}