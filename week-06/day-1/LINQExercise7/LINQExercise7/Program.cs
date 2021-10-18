using System;
using System.Linq;

namespace LINQExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var getCityWithLambda = cities.Where(c => c.StartsWith("A") && c.EndsWith("I")).ToList();
            var getCityWithQuery = from city in cities
                where city.StartsWith("A") && city.EndsWith("I")
                select city;
        }
    }
}