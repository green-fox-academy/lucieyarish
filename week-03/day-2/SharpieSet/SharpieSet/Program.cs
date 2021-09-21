using System;
using System.Collections.Generic;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpiesSet sharpies = new SharpiesSet();
            Sharpie sharpie1 = new Sharpie("blue", 3.5f);
            Sharpie sharpie2 = new Sharpie("red", 4.5f);
            sharpies.Add(sharpie1);
            sharpies.Add(sharpie2);

            Console.WriteLine(sharpies.CountUsable());
        }
    }
}
