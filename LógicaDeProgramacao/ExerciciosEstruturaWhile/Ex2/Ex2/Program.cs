using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the X and Y values: ");
            string[] values = Console.ReadLine().Split(' ');
            int X = int.Parse(values[0]), Y = int.Parse(values[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("First quadrant!");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("Fourth quadrant!");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Second quadrant!");
                }
                else
                {
                    Console.WriteLine("Third quadrant!");
                }

                Console.Write("Insert the X and Y values: ");
                values = Console.ReadLine().Split(' ');
                X = int.Parse(values[0]);
                Y = int.Parse(values[1]);
            }
        }
    }
}