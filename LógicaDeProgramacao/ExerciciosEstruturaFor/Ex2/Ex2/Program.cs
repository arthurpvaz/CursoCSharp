using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the amount of numbers to digit: ");
            int amount = int.Parse(Console.ReadLine());

            int numIn = 0, numOut = 0;

            for(int i = 1; i <= amount; i++)
            {
                Console.Write("Insert a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20)
                {
                    numIn++;
                }
                else
                {
                    numOut++;
                }
            }

            Console.WriteLine("Interval [10, 20]");
            Console.WriteLine($"Numbers in: {numIn}");
            Console.WriteLine($"Numbers out: {numOut}");
        }
    }
}