using System;

namespace Ex1
{
    internal class Retangulo
    {
        public double Largura, Altura;
        
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2.0) + (Altura * 2.0);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
