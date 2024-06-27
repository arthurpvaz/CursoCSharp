using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Insira 4 números =====");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine($"A diferença do produto de AB e BC é {dif}");
        }
    }
}