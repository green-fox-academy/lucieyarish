using System;
using System.Linq;

namespace LINQExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var getCityWithLambda = cities.GroupBy(c => c).To
        }
    }
}