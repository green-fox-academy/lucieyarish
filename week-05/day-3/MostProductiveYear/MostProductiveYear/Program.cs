using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace MostProductiveYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string marvelStudio = "marvel.txt";
            string paramountStudio = "paramount.txt";
            FindMostProductiveYear(marvelStudio);
        }

        public static void FindMostProductiveYear(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                string[] contentStrings = content.Split(new Char [] { ' ', '\n', '\t'});
                List<int> years = new List<int>();
                List<string> notYears = new List<string>();

                foreach (var item in contentStrings)
                {
                    int n;
                    bool isNumber = int.TryParse(item, out n);
                    if (isNumber == true)
                    {
                        years.Add(Convert.ToInt32(n));
                    }
                    else
                    {
                        notYears.Add(item);
                    }
                }
                
                GetFrequencies(years);
                DisplayHighestValue(GetFrequencies(years));
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File doesn't exist!");
            }
            

        }

        private static Dictionary<int, int> GetFrequencies(List<int> values)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int value in values)
            {
                if (result.TryGetValue(value, out int count))
                {
                    result[value] = count + 1;
                }
                else
                {
                    result.Add(value, 1);
                }
            }

            return result;
        }

        private static void DisplayHighestValue(Dictionary<int, int> frequencies)
        {
            int currentValue = 0;
            foreach (var item in frequencies)
            {
                if (item.Value > currentValue)
                {
                    currentValue = item.Value;
                }
            }

            int currentKey = 0;
            foreach (var item in frequencies)
            {
                if (item.Value == currentValue)
                {
                    currentKey = item.Key;
                }
            }
            Console.WriteLine($"{currentKey}");
        }
    }
}