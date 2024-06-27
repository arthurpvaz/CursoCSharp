using System;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0 || num > 100)
            {
                Console.WriteLine("This number is out of interval!");
            }
            else if (num <= 25)
            {
                Console.WriteLine("This number is found at interval [0,25]");
            }
            else if (num <= 50)
            {
                Console.WriteLine("This number is found at interval [25,50]");
            }
            else if (num <= 75)
            {
                Console.WriteLine("This number is found at interval [50,75]");
            }
            else
            {
                Console.WriteLine("This number is found at interval [75,100]");
            }
        }
    }
}