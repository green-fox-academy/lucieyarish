using System;

namespace SimpleReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            string newExample = example.Replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy"
            // in this example variable, but it has a problem
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            Console.WriteLine(newExample);
        }
    }
}
