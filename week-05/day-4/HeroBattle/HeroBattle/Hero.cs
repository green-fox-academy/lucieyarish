using System;

namespace HeroBattle
{
    public class Hero
    {
        public string Name { get; protected set; }
        public double MotivationLevel { get; protected set; }

        public bool IsDCHero { get; protected set; }
        public bool IsMarvelHero { get; protected set; }

        public Hero(string name, double motivationLevel)
        {
            Name = name;
            MotivationLevel = motivationLevel;
        }

        public double GetMotivationLevel()
        {
            if (MotivationLevel <= 25)
            {
                return 0;
            }
            else if (MotivationLevel > 25 && MotivationLevel < 40)
            {
                return 1;                                  
            }
            else if (MotivationLevel >= 40)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        public void Punch(Hero enemy)
        {
            if (this is DCHero && enemy.IsDCHero)
            {
                Console.WriteLine("Can't fight your friend!");
            }
            else if (this is MarvelHero && enemy.IsMarvelHero)
            {
                Console.WriteLine("Can't fight your friend!");
            }
            else
            {
                if (GetMotivationLevel() > 0)
                {
                    double damage = Math.Round(MotivationLevel / 1.5);
                    enemy.BePunched(damage);
                } else
                {
                    Console.WriteLine("I don't have enough motivation to fight you!");
                } 
            }
        }

        public void BePunched(double damage)
        {
            MotivationLevel -= Math.Round(damage / (MotivationLevel / 2));
            if (MotivationLevel < 0)
            {
                MotivationLevel = 0;
            }
        }

        public void GetCurrentMotivationLevel()
        {
            Console.WriteLine($"- {Name}: {MotivationLevel}");
        }

        public string ToString()
        {
            if (MotivationLevel == 0)
            {
                return $"{Name} is not motivated anymore.";
            }
            else if (MotivationLevel == 1)
            {
                return $"{Name} is motivated.";
            }
            else
            {
                return $"{Name} is well-motivated.";
            }
        }
    }
}