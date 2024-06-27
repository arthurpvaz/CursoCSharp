using System;

namespace TestandoEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicativo destinado a testar entrada de dados");
            Console.WriteLine("Digite qualquer frase:");
            string sentence = Console.ReadLine();

            Console.WriteLine($"Você digitou: {sentence}");

            Console.WriteLine("Digite outra frase com quatro palavras para dividir ela nos espaços:");
            string[] s = Console.ReadLine().Split(" ");

            string word0 = s[0], word1 = s[1], word2 = s[2], word3 = s[3];

            Console.WriteLine($"First word: {word0}");
            Console.WriteLine($"Second word: {word1}");
            Console.WriteLine($"Third word: {word2}");
            Console.WriteLine($"Fourth word: {word3}");
        }
    }
}