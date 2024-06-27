using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number to calculate its factorial: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = num;

            if (num > 0)
            {
                for (int i = num - 1; i >= 1; i--)
                {
                    factorial *= i;
                }
            }
            else
            {
                factorial = 1;
            }

            Console.WriteLine($"{num}! = {factorial}");
        }
    }
}