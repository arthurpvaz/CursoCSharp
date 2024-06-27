using System;
using System.Globalization;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário de um cidadão de Lisarb: R$");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0;

            if (sal <= 2000)
            {
                Console.WriteLine("Isento de imposto!");
            }
            else if (sal <= 3000)
            {
                imposto = (sal - 2000) * 0.08;
                Console.WriteLine("Imposto de R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (sal <= 4500)
            {
                imposto = (1000 * 0.08) + ((sal - 3000) * 0.18);
                Console.WriteLine("Imposto de R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = (1000 * 0.08) + (1500 * 0.18) + ((sal - 4500) * 0.28);
                Console.WriteLine("Imposto de R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}