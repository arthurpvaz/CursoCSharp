using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put the first product code: ");
            int code1 = int.Parse(Console.ReadLine());

            Console.Write($"Put the amount of \"{code1}\" part: ");
            int amount1 = int.Parse(Console.ReadLine());

            Console.Write($"Put the price of \"{code1}\": R$");
            double price1 = double.Parse(Console.ReadLine());

            Console.Write("Put the second product code: ");
            int code2 = int.Parse(Console.ReadLine());

            Console.Write($"Put the amount of \"{code2}\" part: ");
            int amount2 = int.Parse(Console.ReadLine());

            Console.Write($"Put the price of \"{code2}\": R$");
            double price2 = double.Parse(Console.ReadLine());

            double total = (amount1 * price1) + (amount2 * price2);

            Console.WriteLine($"The total price to pay is R${total:F2}");
        }
    }
}