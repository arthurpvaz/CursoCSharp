using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fuels: (1) Alcohol -- (2) Gasoline -- (3) Diesel -- (4) End");

            Console.Write("Insert the fuel type code you wish: ");
            int code = int.Parse(Console.ReadLine());

            int alc = 0, gas = 0, diesel = 0;

            while (code != 4)
            {
                if (code == 1)
                {
                    alc++;
                }
                else if (code == 2)
                {
                    gas++;
                }
                else if (code == 3)
                {
                    diesel++;
                }

                Console.Write("Insert the fuel type code you wish: ");
                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you!");
            Console.WriteLine($"Alcohool: {alc}");
            Console.WriteLine($"Gasoline: {gas}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}