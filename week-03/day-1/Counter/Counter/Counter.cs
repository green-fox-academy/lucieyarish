using System;
namespace Counter
{
    public class Counter
    {
        public int CounterProp { get; set; }

        public Counter()
        {
            CounterProp = 0;
        }

        public Counter(int addnumber)
        {
            CounterProp = addnumber;
        }

        public void Add(int number)
        {
            CounterProp += number;
            Console.WriteLine($"Counter value is: {CounterProp}");
        }

        public void Add()
        {
            CounterProp++;
            Console.WriteLine($"Counter value is: {CounterProp}");
        }

        public void Get()
        {
            Console.WriteLine($"Counter value is: {CounterProp}");
        }

        public void Reset()
        {
            CounterProp = 0;
            Console.WriteLine(CounterProp);
        }

    }
}
