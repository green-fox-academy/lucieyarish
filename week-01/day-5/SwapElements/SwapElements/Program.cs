using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            string[] orders = { "first", "second", "third" };
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`
            string temp = orders[0];
            orders[0] = orders[2];
            orders[2] = temp;

            foreach (string order in orders)
            {
                Console.Write(order + " ");
            }

            Console.ReadLine();
        }
    }
}
