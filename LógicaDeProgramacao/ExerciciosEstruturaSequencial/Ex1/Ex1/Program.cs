using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put two numbers and the program will get out the sum of them");
            
            Console.Write("N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("N2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of the numbers: {n1 + n2}");
        }
    }
}