using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert an integer number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Its dividers are: ");

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i}; ");
                }
            }
        }
    }
}