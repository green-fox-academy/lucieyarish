using System;
using System.Collections.Generic;
namespace SharpieSet
{
    public class Sharpie
    {
        public string Color;
        public float Width;
        public float InkAmount = 100;

        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
        }

        public void Use()
        {
            InkAmount -= 10;
            Console.WriteLine($"Current ink amount is {InkAmount}");
        }
    }
}
