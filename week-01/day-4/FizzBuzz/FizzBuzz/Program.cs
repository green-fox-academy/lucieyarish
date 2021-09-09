﻿using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100

            for (int i = 0; i <=100; i++)
            {
                // but for multiples of three print “Fizz” instead of the number
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                // and for the multiples of five print “Buzz”
                }  else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                // For numbers which are multiples of both three and five print “FizzBuzz”
                } else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                } else
                {
                    Console.WriteLine(i);
                }

                
            }


            
        }
    }
}
