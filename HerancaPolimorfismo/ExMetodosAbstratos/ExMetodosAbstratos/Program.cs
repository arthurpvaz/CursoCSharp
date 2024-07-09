using System.Globalization;
using ExMetodosAbstratos.Entities;
using ExMetodosAbstratos.Entities.Enums;

namespace ExMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= num; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                TypeOfTaxPayer option = char.Parse(Console.ReadLine().ToUpper()); // ver melhor método de implementar

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: $ ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (option == TypeOfTaxPayer.Individual)
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (option == TypeOfTaxPayer.Company)
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("Type of tax payer invalid!");
                }
            }

            Console.WriteLine("\nTAXES PAID:");

            foreach (var taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
            }
        }
    }
}