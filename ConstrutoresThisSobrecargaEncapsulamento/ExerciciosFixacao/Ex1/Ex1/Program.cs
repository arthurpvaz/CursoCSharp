using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char depoistoInicial = char.Parse(Console.ReadLine());

            ContaBanco contaBanco = null;

            if(depoistoInicial == 's' || depoistoInicial == 'S')
            {
                Console.Write("Entre  o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBanco = new ContaBanco(numero, titular, depositoInicial);
            }
            else
            {
                contaBanco = new ContaBanco(numero, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBanco);

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaBanco.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBanco);

            Console.Write("Entre com um valor de saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaBanco.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBanco);
        }
    }
}