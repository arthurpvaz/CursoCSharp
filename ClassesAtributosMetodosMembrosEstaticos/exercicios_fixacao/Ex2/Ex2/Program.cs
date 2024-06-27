using Ex2;
using System;
using System.Globalization;

namespace Ex3
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Funcionario f1 = new Funcionario();
            
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: R$");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: R$");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {f1.Nome}, $ {f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            f1.AumentarSalario(imposto);

            Console.WriteLine($"Dados atualizados: {f1.Nome}, $ {f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}