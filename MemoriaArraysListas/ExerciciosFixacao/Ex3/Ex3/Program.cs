using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rand.Next(5) == 3)
                    {
                        matrix[i, j] = (rand.Next(9) + 1) * - 1;
                    }
                    else
                    {
                        matrix[i, j] = rand.Next(10);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Main diagonal:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }

            int count = 0;

            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.Write("\nNegative numbers: " + count);
        }
    }
}