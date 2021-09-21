using System;
using System.Collections.Generic;

namespace FleetOfThings2
{
    public class Things
    {
        public string Name;
        public bool Completed;

        public Things(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
    }
}
