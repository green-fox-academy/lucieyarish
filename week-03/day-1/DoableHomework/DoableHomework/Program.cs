using System;
using System.Collections.Generic;

namespace DoableHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            CoconutTree();
            GiantSequoia();
            WillowTree();
            Sakura();
            BirchTree();
        }

        private static void BirchTree()
        {
            string type = "deciduous";
            string leafColor = "green";
            int age = 12;
            string sex = "M";
            Console.WriteLine($"Birch tree tree type: {type}, leaf color: {leafColor}, age: {age}, sex: {sex}");
        }

        private static void Sakura()
        {
            string type = "deciduous";
            string leafColor = "green";
            int age = 5;
            string sex = "F";
            Console.WriteLine($"Sakura tree type: {type}, leaf color: {leafColor}, age: {age}, sex: {sex}");
        }

        private static void WillowTree()
        {
            string type = "deciduous";
            string leafColor = "green";
            int age = 24;
            string sex = "F";
            Console.WriteLine($"Willow tree type: {type}, leaf color: {leafColor}, age: {age}, sex: {sex}");
        }

        private static void GiantSequoia()
        {
            string type = "pine";
            string leafColor = "green";
            int age = 68;
            string sex = "M";
            Console.WriteLine($"Giant sequoia tree type: {type}, leaf color: {leafColor}, age: {age}, sex: {sex}");
        }

        private static void CoconutTree()
        {
            string type = "palm";
            string leafColor = "green";
            int age = 17;
            string sex = "F";
            Console.WriteLine($"Coconut tree type: {type}, leaf color: {leafColor}, age: {age}, sex: {sex}");

        }
    }
}
