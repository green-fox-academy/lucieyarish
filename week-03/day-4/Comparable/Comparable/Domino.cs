using System;
using System.Collections.Generic;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino other)
        {
            int returnValue;
            if (this.Values[0] > other.Values[0])
            {
                returnValue = 1;
            }
            else if (this.Values[0] < other.Values[0])
            {
                returnValue = -1;
            }
            else
            {
                returnValue = 0;
                if (this.Values[1] > other.Values[1])
                {
                    returnValue = 1;
                }
                else if (this.Values[1] < other.Values[1])
                {
                    returnValue = -1;
                }
            }
            return returnValue;  
        }

        public int[] GetValues()
        {
            return Values;
        }

        public string Print()
        {
            return $"[{Values[0]} | {Values[1]}]";
        }
    }
}
