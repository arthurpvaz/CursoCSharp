using System;

namespace Bhaskara
{
    internal class Program
    {
        static void Main(string[]args)
        {
            float a = 3.0F, b = 6.0F, c = 2.0F;

            float delta = (float)Math.Pow(b, 2.0F) - 4.0F * a * c;

            float x1 = (-b + (float)Math.Sqrt(delta)) / (2.0F * a);
            float x2 = (-b - (float)Math.Sqrt(delta)) / (2.0F * a);

            Console.WriteLine($"The result of the 3X^2 + 6X + 9 is x1 = {x1:F2} or x2 = {x2:F2}");        }
    }
}