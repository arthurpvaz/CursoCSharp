using System;
using System.Globalization;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int code = 5290;

            char genre = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine("{0}, whose price is ${1:F2}", product1, price1);
            Console.WriteLine($"{product2}, whose price is ${price2:F2}");
            Console.WriteLine("");
            Console.WriteLine("Register: " + age + " years old, code " + code.ToString("F0") + " and genre: " +  genre);
            Console.WriteLine("");
            Console.WriteLine("Measure with eight decimal places: {0:F8}", measure);
            Console.WriteLine($"Rounding (three decimal places): {measure:F3}");
            Console.WriteLine("Decimal separator invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}