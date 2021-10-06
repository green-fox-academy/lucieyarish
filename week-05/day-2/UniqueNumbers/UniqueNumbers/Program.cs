using System;
using System.Collections.Generic;
using System.Net;

namespace UniqueNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write a method which takes a 2D array / matrix
            //containing integer numbers. It returns the numbers
            //in a list without any duplication.
            //Write 2 different unit test cases for the method.
            
            int[,] input1 =
            {
                {1}, {1},
                {4}, {2}
            };
            // Expected output: [1, 4, 2]

            int[,] input2 =
            {
                {4, 3, -1},
                {10, 2, 5},
                {-2, 3, 4}
            };
            // Expected output: [4, 3, -1, 10, 2, 5, -2]

            UniqueNumbersGenerator(input1);
            // foreach (var VARIABLE in UniqueNumbersGenerator(input2))
            // {
            //     Console.Write(VARIABLE + ", ");
            // }
        }
        
        public static List<int> UniqueNumbersGenerator(int[,] input)
        {
            var uniqueNums = new List<int>();
            foreach (var item in input)
            {
                if (uniqueNums.Contains(item) == false)
                {
                    uniqueNums.Add(item);
                }
            }
            return uniqueNums;
        }
    }
}