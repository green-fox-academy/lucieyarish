using System;
namespace Sharpie
{
    public class Sharpie
    {
        private string Color;
        private float Width;
        private float InkAmount = 100;

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
