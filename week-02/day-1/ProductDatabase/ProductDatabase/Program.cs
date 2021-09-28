using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productDatabase = new Dictionary<string, int>
            {
                {"Eggs", 200},
                {"Milk", 200},
                {"Fish", 400},
                {"Apples", 150},
                {"Bread", 50},
                {"Chicken", 550},
            };
            
            GetFishPrice(productDatabase);
            MostExpItem(productDatabase);
            AveragePrice(productDatabase);
            LessThan300(productDatabase);
            ItemsFor125(productDatabase);
            CheapestItem(productDatabase);
        }

        private static void CheapestItem(Dictionary<string, int> dictionaryName)
        {
            Console.WriteLine(dictionaryName.Values.Min());
        }

        private static void ItemsFor125(Dictionary<string, int> dictionaryName)
        {
            foreach (var item in dictionaryName)
            {
                if (item.Value <= 125)
                {
                    Console.WriteLine($"You can buy {item.Key} for less than 125!");
                }
            }
        }

        private static void LessThan300(Dictionary<string, int> dictionaryName)
        {
            int count = 0;
            foreach (var item in dictionaryName)
            {
                if (item.Value < 300)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void AveragePrice(Dictionary<string, int> dictionaryName)
        {
            int sumAll = 0;
            foreach (var item in dictionaryName)
            {
                int itemValue = item.Value;
                sumAll += itemValue;
            }
            Console.WriteLine(sumAll / dictionaryName.Count);
        }

        private static void MostExpItem(Dictionary<string, int> dictionaryName)
        {
            Console.WriteLine(dictionaryName.Values.Max());
        }

        private static void GetFishPrice(Dictionary<string, int> dictionaryName)
        {
            Console.WriteLine(dictionaryName.GetValueOrDefault("Fish"));
        }
    }
}