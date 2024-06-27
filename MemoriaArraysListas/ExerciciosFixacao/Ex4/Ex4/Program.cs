using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)

        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(10);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }

            int option = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == option)
                    {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        }

                        if (j + 1 <= matrix.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {matrix[i - 1, j]}");
                        }

                        if (i + 1 <= matrix.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Down: {matrix[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}