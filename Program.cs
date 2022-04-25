using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("My name is " + lastName + "," + firstName + " " + lastName); 

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Max value" + max);


        }
    }
}