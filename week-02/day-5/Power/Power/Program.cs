using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given base and n that are both 1 or more, compute recursively(no loops)
            //the value of base to the n power, so powerN(3, 2) is 9(3 squared).

            Console.WriteLine(PowerWithRecursion(3, 2));
        }

        private static int PowerWithRecursion(int baseNum, int powerN)
        {
            if (baseNum == 1 || powerN == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * PowerWithRecursion(baseNum, powerN - 1);
            }
        }
    }
}
