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

                        DateTime manufactureDate = new DateTime(int.Parse(dateString[2]), int.Parse(dateString[1]), int.Parse(dateString[0]));

                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case 'I':
                        Console.Write("Customs fee: $ ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            
            foreach (Product product in products)
            {
                if(product is ImportedProduct)
                {
                    Console.WriteLine((product as ImportedProduct).PriceTag());
                }
                else if (product is UsedProduct)
                {
                    Console.WriteLine((product as UsedProduct).PriceTag());
                }
                else
                {
                    Console.WriteLine(product.PriceTag());
                }
            }
        }
    }
}