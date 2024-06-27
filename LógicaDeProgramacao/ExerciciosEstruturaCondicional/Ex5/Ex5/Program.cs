using System;
using System.Globalization;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código       Especificação       Preço");
            Console.WriteLine("1            Cachorro Quente     R$ 4.00");
            Console.WriteLine("2            X-salada            R$ 4.50");
            Console.WriteLine("3            X-bacon             R$ 5.00");
            Console.WriteLine("4            Torrada simples     R$ 2.00");
            Console.WriteLine("5            Refrigerante        R$ 1.50");

            Console.Write("Insert the code and the amount of the item you want: ");

            string[] values = Console.ReadLine().Split(' ');

            Console.WriteLine("");

            int code = int.Parse(values[0]);
            int amount = int.Parse(values[1]);
            double total = 0.0;

            if (amount >= 1)
            {
                if (code == 1)
                {
                    total = (double)amount * 4.00;
                    Console.WriteLine("Total to pay: $" + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (code == 2)
                {
                    total = (double)amount * 4.50;
                    Console.WriteLine("Total to pay: $" + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (code == 3)
                {
                    total = (double)amount * 5.00;
                    Console.WriteLine("Total to pay: $" + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (code == 4)
                {
                    total = (double)amount * 2.00;
                    Console.WriteLine("Total to pay: $" + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (code == 5)
                {
                    total = (double)amount * 1.50;
                    Console.WriteLine("Total to pay: $" + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("This product not exist!");
                }
            }
            else
            {
                Console.WriteLine("You have to choose at least one unit of the product!");
            }
        }
    }
}