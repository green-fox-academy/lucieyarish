using System;
using System.Collections.Generic;
using System.IO;

namespace A66Entering
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "doorLogs.txt";
            A66ChipUsageInfo(path);
        }

        public static Dictionary<string, int> A66ChipUsageInfo(string path)
        {
            string[] allLogs = File.ReadAllLines(path);
            List<string> mainDoor = new List<string>();
            foreach (var item in allLogs)
            {
                if (item.Contains("MAIN"))
                {
                    mainDoor.Add(item);
                }
            }

            List<string> cards = new List<string>();
            foreach (var log in mainDoor)
            {
                cards.Add(log.Substring(log.Length - 11));
            }

            Dictionary<string, int> cardMainDoorUsageCount = new Dictionary<string, int>();
            foreach (string item in cards)
            {
                if (cardMainDoorUsageCount.ContainsKey(item))
                {
                    cardMainDoorUsageCount[item]++;
                }
                else
                {
                    cardMainDoorUsageCount.Add(item, 1);
                }
            }
            PrintAll(cardMainDoorUsageCount);
            return cardMainDoorUsageCount;
        }

        private static void PrintAll(Dictionary<string, int> collectionToPrint)
        {
            foreach (var keyValPair in collectionToPrint)
            {
                Console.WriteLine(keyValPair);
            }
        }
    }
}