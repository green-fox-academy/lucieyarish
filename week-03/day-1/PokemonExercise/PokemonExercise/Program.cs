using System;
using System.Collections.Generic;

namespace PokemonExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", "grass", "water");

            // Which pokemon should Ash use?

            //Console.Write("I choose you, {0}", pokemonOfAsh[4].Name);

            foreach (var pokemon in pokemonOfAsh)
            {
                if(pokemon.IsEffectiveAgainst(wildPokemon))
                {
                    Console.Write("I choose you, " + pokemon.Name);
                }
            }


        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "grass", "water"),
                new Pokemon("Pikachu", "electric", "water"),
                new Pokemon("Charizard", "fire", "grass"),
                new Pokemon("Pidgeot", "flying", "fighting"),
                new Pokemon("Kingler", "water", "fire")
            };
        }
    }
}
