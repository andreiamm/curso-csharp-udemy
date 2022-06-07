using System;
using System.Globalization;

namespace glicose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string classificacao;

            Console.Write("Digite a medida da glicose: ");
            float medida = float.Parse(Console.ReadLine(), CI);

            if (medida <= 100.0f)
            {
                classificacao = "normal";
            }
            else if (medida <= 140.0f)
            {
                classificacao = "elevado";
            }
            else
            {
                classificacao = "diabetes";
            }

            Console.WriteLine($"Classificacao: {classificacao}");

            Console.ReadLine();
        }
    }
}
