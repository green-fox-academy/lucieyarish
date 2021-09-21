using System;
using System.Collections.Generic;

namespace SharpieSet
{
    public class SharpiesSet
    {
        List<Sharpie> Sharpies;

        public SharpiesSet()
        {
            Sharpies = new List<Sharpie>();
        }

        public void Add(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }

        public int CountUsable()
        {
            int count = 0;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmount > 0)
                {
                    count++;
                }
            }
            return count;
            
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmount == 0)
                {
                    Sharpies.RemoveAt(i);
                }
            }
        }
    }
}
