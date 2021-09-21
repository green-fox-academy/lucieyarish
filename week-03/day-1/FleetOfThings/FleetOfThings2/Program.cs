using System;

namespace FleetOfThings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            Things item1 = new Things("milk");
            Things item2 = new Things("Remove the obstacles");
            Things item3 = new Things("Stand up");
            Things item4 = new Things("Eat lunch!");
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
