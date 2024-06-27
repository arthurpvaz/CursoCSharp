using System;
using System.Globalization;

namespace Ex3
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public void Situacao()
        {
            if (NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {(60.0 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
