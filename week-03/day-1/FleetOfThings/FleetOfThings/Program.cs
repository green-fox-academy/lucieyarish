using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            Thing item1 = new Thing("milk");
            Thing item2 = new Thing("Remove the obstacles");
            Thing item3 = new Thing("Stand up");
            Thing item4 = new Thing("Eat lunch!");
            item3.Complete();
            item4.Complete();

            fleet.Add(item1);
            fleet.Add(item2);
            fleet.Add(item3);
            fleet.Add(item4);
            fleet.PrintAll();

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
        }
    }
}
