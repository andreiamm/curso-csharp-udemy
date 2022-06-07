using System;
using System.Globalization;

namespace baskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Coeficiente a: ");
            double a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            double b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            double c = double.Parse(Console.ReadLine(), CI);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            } 
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"X1 = {x1.ToString("F4", CI)}");
                Console.WriteLine($"X2 = {x2.ToString("F4", CI)}");
            }
        }
    }
}
