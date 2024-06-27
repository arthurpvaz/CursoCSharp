using System;
using System.Globalization;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert how many times the program will run: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                Console.Write("Insert the numbers to divide: ");
                string[] values = Console.ReadLine().Split(' ');

                double n1 = double.Parse(values[0]);
                double n2 = double.Parse(values[1]);

                if (n2 != 0)
                {
                    Console.WriteLine("Result: " + (n1 / n2).ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Impossible division!");
                }
            }
        }
    }
}