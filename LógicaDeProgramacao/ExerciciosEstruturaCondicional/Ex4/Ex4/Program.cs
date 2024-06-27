using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the start time and the finish time of the game: ");

            string[] horarios = Console.ReadLine().Split(' ');
            int startTime = int.Parse(horarios[0]);
            int endTime = int.Parse(horarios[1]);

            int totalTime = 0;

            if (endTime > startTime)
            {
                totalTime = endTime - startTime;
            }
            else
            {
                totalTime = 24 - startTime + endTime;
            }

            Console.WriteLine($"The game lasted {totalTime} hours");
        }
    }
}