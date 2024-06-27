using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a whole number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else
            {
                Console.WriteLine("This number is odd!");
            }
        }
    }
}