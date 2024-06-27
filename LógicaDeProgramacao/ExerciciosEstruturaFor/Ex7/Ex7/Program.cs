using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}