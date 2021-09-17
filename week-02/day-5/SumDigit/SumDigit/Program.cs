using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a non - negative integer n, return the sum
            //of its digits recursively(without loops).
            Console.WriteLine(SumDigits(123.ToString()));
        }

        private static int SumDigits(string numToDigits)
        {
            int firstNumber = int.Parse(numToDigits.Substring(0, 1));

            if (numToDigits.Length <= 1)
            {
                return firstNumber;
            }
            else
            {
                return firstNumber + (SumDigits(numToDigits.Substring(1)));
            }
        }
    }
}
