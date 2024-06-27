using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a whole number: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("This number is not negative!");
            }
            else
            {
                Console.WriteLine("This number is negative!");
            }
        }
    }
}