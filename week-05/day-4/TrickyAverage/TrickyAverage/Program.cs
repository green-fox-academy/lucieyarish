using System;

namespace TrickyAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 3, 4, 5, 6};
            int[] numbers2 = { 5, 2, 8, -1};

            Console.WriteLine(GetTrickyAvg(numbers2));
        }

        public static double GetTrickyAvg(int[] numbers)
        {
            double currentLargestEven = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0 && item > currentLargestEven)
                {
                    currentLargestEven = item;
                }
            }

            double currentSmallestOdd = 0;
            foreach (var item in numbers)
            {
                if (item < currentSmallestOdd)
                {
                    currentSmallestOdd = item;
                }
            }

            double trickyAverage = (currentLargestEven + currentSmallestOdd) / 2;
            
            return trickyAverage;
        }
    }
}