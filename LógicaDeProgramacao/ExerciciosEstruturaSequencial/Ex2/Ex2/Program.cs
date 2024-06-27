using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calcula círculo ---------");
            Console.Write("Insira o valor do raio do círculo: ");

            double raio = double.Parse(Console.ReadLine());

            double cA = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"A área total do círculo de raio {raio:F2} é: {cA:F4}");
        }
    }
}