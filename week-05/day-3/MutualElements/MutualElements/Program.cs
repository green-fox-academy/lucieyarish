using System;
using System.Collections.Generic;

namespace MutualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums1 = new List<int>
            {
                1, 1, 2, 3, 3, 4
            };
            
            List<int> listOfNums2 = new List<int>
            {
                3, 4, 4, 5, 6
            };
            
            GetMutualElements(listOfNums1, listOfNums2);
        }

        private static void DisplayMutualValues(List<int> mutualElements)
        {
            foreach (var item in mutualElements)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> GetMutualElements(List<int> listOfNums1, List<int> listOfNums2)
        {
            List<int> mutualElements = new List<int>();

            foreach (int item in listOfNums1)
            {
                if (listOfNums2.Contains(item) && !mutualElements.Contains(item))
                {
                    mutualElements.Add(item);
                }
            }
            foreach (var item in listOfNums2)
            {
                if (listOfNums1.Contains(item) && !mutualElements.Contains(item))
                {
                    mutualElements.Add(item);
                }
            }
            
            DisplayMutualValues(mutualElements);
            return mutualElements;
        }
        
        
    }
}