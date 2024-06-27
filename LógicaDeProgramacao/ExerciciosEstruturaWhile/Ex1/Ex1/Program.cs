using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the correct password: ");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Invalid password!");
                Console.Write("Insert the correct password: ");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Access allowed!");
        }
    }
}