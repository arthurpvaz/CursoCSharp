using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put here your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many rooms are in your house? ");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Put here a price of a product: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Put your last name, age and your height (in same line):");
            string[] array = Console.ReadLine().Split(" ");

            string last = array[0];
            int age = int.Parse(array[1]);
            double height = double.Parse(array[2]);

            Console.WriteLine($"Your name: {name}");
            Console.WriteLine($"The amount of rooms in your house: {rooms}");
            Console.WriteLine($"The price of your product is ${price}");
            Console.WriteLine($"Your last name is: {last}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"You are {height} meters tall");
        }
    }
}