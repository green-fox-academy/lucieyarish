using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above
            int secondsInMinute = 60;
            int secondsInHour = 3600;
            int secondsInDay = 3600 * 24;

            int remainingSeconds = secondsInDay - (currentHours * secondsInHour) - (currentMinutes * secondsInMinute) - 42;

            Console.WriteLine(remainingSeconds);
        }
    }
}
