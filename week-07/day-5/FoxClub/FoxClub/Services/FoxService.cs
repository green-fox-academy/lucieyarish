using System.Collections.Generic;
using System.Linq;

namespace FoxClub.Services
{
    public class FoxService
    {
        public List<Fox> Foxes { get; set; }
        public Fox LoggedFox { get; set; }
        public FoxService()
        {
            Foxes = new List<Fox>();
            LoggedFox = new Fox("Green");
        }

        public bool ContainsFox(string name)
        {
            foreach (var fox in Foxes)
            {
                if (name == fox.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddFox(string name)
        {
            if (!ContainsFox(name))
            {
                Foxes.Add(new Fox(name));
                LoggedFox = Foxes[Foxes.Count - 1];
            }
        }

        // public Fox GetFox(string name)
        // {
        //     var result = Foxes.FirstOrDefault(f => f.Name == name);
        //     return result;
        // }

        public void AddTrick(string trick)
        {
            if (!LoggedFox.Tricks.Contains(trick))
            {
                LoggedFox.Tricks.Add(trick);
            }
        }
    }
}