using System;

namespace VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            a = 3 + 10;

            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b = 100 - 7;

            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c = 44 * 2;

            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d = 125 / 5;

            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e = 8 * 8 * 8;

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool isf1BiggerThanf2 = f2 > f1;

            Console.WriteLine(isf1BiggerThanf2);

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool isDoubleOfg2BiggerThang1 = g2 > g1;

            Console.WriteLine(isDoubleOfg2BiggerThang1);

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            long remainder = h % 11;

            bool isDivisor = remainder == 0;

            Console.WriteLine(isDivisor);


            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            int i2Squared = 3 * 3;
            int i2Cubed = 3 * 3 * 3;

            bool isHigherAndSmaller = i1 > i2Squared && i1 < i2Cubed;

            Console.WriteLine(isHigherAndSmaller);

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
            bool isDivisible = (j % 3 == 0) || (j % 5 == 0);

            Console.WriteLine(isDivisible);
        }
    }
}
