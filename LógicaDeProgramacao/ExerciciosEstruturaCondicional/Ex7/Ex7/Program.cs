using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert two decimal values as coordinates: ");
            string[] values = Console.ReadLine().Split(' ');

            double X = double.Parse(values[0]);
            double Y = double.Parse(values[1]);

            if (X == 0)
            {
                if (Y == 0)
                {
                    Console.WriteLine("Origin point!");
                }
                else if (Y != 0)
                {
                    Console.WriteLine("Y-axis!");
                }
            }
            else if (Y == 0)
            {
                Console.WriteLine("X-axis!");
            }
            else if (X > 0)
            {
                if (Y > 0)
                {
                    Console.WriteLine("Quadrant 1!");
                }
                else
                {
                    Console.WriteLine("Quadrant 4!");
                }
            }
            else
            {
                if (Y > 0)
                {
                    Console.WriteLine("Quadrant 2!");
                }
                else
                {
                    Console.WriteLine("Quadrant 3!");
                }
            }
        }
    }
}