using System;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor numérico para a letra A: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira um valor numérico para a letra B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira um valor numérico para a letra C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A área do triângulo retângulo cuja base esquivale a " + A + " e altura equivale a " + C + " é: " + (((A * C) / 2)).ToString("F3", CultureInfo.InvariantCulture));
            
            double circulo = 3.14159 * Math.Pow(C, 2);
            Console.WriteLine("A área do círculo cujo raio equivale a " + C.ToString("F3", CultureInfo.InvariantCulture) + " é: " + circulo.ToString("F3", CultureInfo.InvariantCulture));

            double trapezio = ((A + B) * C) / 2;
            Console.WriteLine("A área do trapézio cujas bases equivalem a " + A.ToString("F3", CultureInfo.InvariantCulture) + " e " + B.ToString("F3", CultureInfo.InvariantCulture) + " e altura equivale a " + C + " é: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do quadrado cujo lado equivale a " + B.ToString("F3", CultureInfo.InvariantCulture) + " é: " + (Math.Pow(B, 2)).ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do retângulo cuja base equivale a " + A.ToString("F3", CultureInfo.InvariantCulture) + " e altura equivale a " + B.ToString("F3", CultureInfo.InvariantCulture) + " é: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
