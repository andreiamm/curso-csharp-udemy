using System;
using System.Globalization;

namespace dados_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, qtdeMulheres;
            float somaAlturaMulheres, menorAltura, maiorAltura;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            float[] alturas = new float[n];
            char[] generos = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Altura da {i + 1}a pessoa: ");
                alturas[i] = float.Parse(Console.ReadLine(), CI);
                Console.Write($"Genero da {i + 1}a pessoa: ");
                generos[i] = char.Parse(Console.ReadLine());
            }

            somaAlturaMulheres = 0;
            qtdeMulheres = 0;
            menorAltura = alturas[0];
            maiorAltura = alturas[0];
            for (int i = 0; i < n; i++)
            {
                if (generos[i] == 'F' || generos[i] == 'f')
                {
                    somaAlturaMulheres += alturas[i];
                    qtdeMulheres++;
                }

                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }

                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }
            }

            Console.WriteLine($"Menor altura = {menorAltura.ToString("F2", CI)}");
            Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2", CI)}");
            Console.WriteLine($"Media das alturas das mulheres = {(somaAlturaMulheres / qtdeMulheres).ToString("F2", CI)}");
            Console.WriteLine($"Numero de homens = {n - qtdeMulheres}");
        }
    }
}
