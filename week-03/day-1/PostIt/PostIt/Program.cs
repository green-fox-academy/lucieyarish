using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("orange", "Idea 1", "blue");
            postIt1.PrintPostItColor();

            PostIt postIt2 = new PostIt("pink", "Awesome", "black");
            postIt2.PrintPostItColor();

            PostIt postIt3 = new PostIt("yellow", "Superb!", "green");
            postIt3.PrintPostItColor();
        }
    }
}
