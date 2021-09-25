using System;
using System.Collections.Generic;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ship.AddPirate(new Pirate("One-eyed Joe"));
            ship.AddPirate(new Pirate("Black Beard"));
            ship.AddPirate(new Pirate("Bottleneck Bill"));
            ship.AddPirate(new Pirate("Drunk Dave"));
            ship.AddPirate(new Pirate("Awesome Al"));
            
            ship.PrintAll();
            

        }
    }
}