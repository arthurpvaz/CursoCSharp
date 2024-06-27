using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127; // (-128 a 127)
            int b = 10239;
            long c = 19283798123L; // aceita números maiores (se for tipo long precisa colocar o L no final);
            bool d = true;
            char e = 'a';
            char f = '\u0041'; // colocar letra ou unicode;
            float g = 1.5f; // necessário acrescentar a letra f no fim
            double h = 1.5;
            string i = "hello"; // não é um tipo primitivo e é imutável

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(int.MinValue); // número mínimo do tipo int
            Console.WriteLine(int.MaxValue); // número máximo do tipo int
        }
    }
}