using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter myCounter = new Counter();
            myCounter.Add();
            myCounter.Add(2);
            myCounter.Get();
            myCounter.Reset();
        }
    }
}
