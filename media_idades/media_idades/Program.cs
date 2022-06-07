using System;
using System.Globalization;

namespace media_idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, soma, contador;

            Console.WriteLine("Digite as idades:");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                soma = 0;
                contador = 0;
                while (idade >= 0)
                {
                    soma += idade;
                    contador++;
                    idade = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"MEDIA = {((float)soma / contador).ToString("F2", CI)}");
            }            
        }
    }
}
