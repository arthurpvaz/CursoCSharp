using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número do funcionário: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Insira o número de horas trabalhadas: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor ganho por hora: R$");
            double vph = double.Parse(Console.ReadLine());

            double sal = vph * h;

            Console.WriteLine($"Nº funcionário: {num}");
            Console.WriteLine($"Salário: R$ {sal}");
        }
    }
}