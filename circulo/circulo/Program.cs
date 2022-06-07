using System;
using System.Globalization;

namespace circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor do raio do circulo: ");
            float raio = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"AREA = {(Math.PI * Math.Pow(raio, 2)).ToString("F3", CI)}");

            Console.ReadLine();
        }
    }
}
