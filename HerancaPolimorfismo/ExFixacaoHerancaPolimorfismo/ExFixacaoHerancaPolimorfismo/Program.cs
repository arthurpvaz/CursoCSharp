using System;
using System.Globalization;
using ExFixacaoHerancaPolimorfismo.Entities;

namespace ExFixacaoHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productOption = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: $ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (Char.ToUpper(productOption))
                {
                    case 'C':
                        products.Add(new Product(name, price));
                        break;

                    case 'U':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        string[] dateString = Console.ReadLine().Split("/");

                        DateTime manufactureDate = 
                        products.Add(new (name, price));
                        break;
                }
            }
        }
    }
}