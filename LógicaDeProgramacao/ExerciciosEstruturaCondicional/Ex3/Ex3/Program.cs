using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Insert two whole numbers");
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                if (A % B == 0)
                {
                    Console.WriteLine("These number are multiples!");
                }
                else
                {
                    Console.WriteLine("This numbers are not multiples!");
                }
            }
            else
            {
                if (B % A == 0)
                {
                    Console.WriteLine("These numbers are multiples!");
                }
                else
                {
                    Console.WriteLine("These numbers are not multiples!");
                }
            }
        }
    }
}