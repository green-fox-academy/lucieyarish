using System;
using System.Collections.Generic;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            Flower yellowFlower = new Flower("yellow", "flower");
            plants.Add(yellowFlower);
            Flower blueFlower = new Flower("blue", "flower");
            plants.Add(blueFlower);

            Tree purpleTree = new Tree("purple", "tree");
            plants.Add(purpleTree);
            Tree orangeTree = new Tree("orange", "tree");
            plants.Add(orangeTree);


        }
    }
}
