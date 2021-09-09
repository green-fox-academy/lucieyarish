using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User
            Console.WriteLine("Hi, what's your name?");
            string UserName = Console.ReadLine();

            Console.WriteLine("Hello " + UserName);
        }
    }
}
