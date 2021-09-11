using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            double cuboidSideSize = 10;

            double cuboidSurface = (cuboidSideSize * cuboidSideSize) * 6;
            double cuboidVolume = Math.Pow(cuboidSideSize, 3);

            // Surface Area: 600
            // Volume: 1000


            Console.WriteLine(cuboidSurface);
            Console.WriteLine(cuboidVolume);

            Console.ReadLine();
        }
    }
}
