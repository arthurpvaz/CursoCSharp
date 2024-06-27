using System;
using System.Globalization;

namespace Ex3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            
            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            a1.Situacao();
        }
    }
}