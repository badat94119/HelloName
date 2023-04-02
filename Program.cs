using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");

            string yourName = Console.ReadLine();

            Console.WriteLine("Hello: " + yourName);
        }
    }
}
