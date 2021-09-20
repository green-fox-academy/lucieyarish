using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal crocodile = new Animal(50, 50);
            crocodile.Eat();
            crocodile.Drink();
            crocodile.Play();
        }
    }
}
