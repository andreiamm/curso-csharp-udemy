using System;
using System.Globalization;

namespace media_ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            float n1, n2, n3, media;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite tres numeros:");
                n1 = float.Parse(Console.ReadLine(), CI);
                n2 = float.Parse(Console.ReadLine(), CI);
                n3 = float.Parse(Console.ReadLine(), CI);

                media = (n1 * 2.0f + n2 * 3.0f + n3 * 5.0f) / 10.0f;
                Console.WriteLine($"MEDIA = {media.ToString("F1", CI)}");
            }

        }
    }
}
