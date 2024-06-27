using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the amount of average grades to calculate: ");
            int N = int.Parse(Console.ReadLine());

            double[] averages = new double[N + 1];

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Insert the three grades: ");
                string[] grades = Console.ReadLine().Split(' ');

                double g1 = double.Parse(grades[0]), g2 = double.Parse(grades[1]), g3 = double.Parse(grades[2]);

                double average = (2.0 * g1 + 3.0 * g2 + 5.0 * g3) / 10.0;

                averages[i] = average;
            }

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Average " + i + ": " + averages[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}