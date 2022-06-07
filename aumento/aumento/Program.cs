using System;
using System.Globalization;

namespace aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int porcentagem;

            Console.Write("Digite o salario da pessoa: ");
            float salario = float.Parse(Console.ReadLine(), CI);

            if (salario <= 1000.0f)
            {
                porcentagem = 20;
            }
            else if (salario <= 3000.0f)
            {
                porcentagem = 15;
            }
            else if (salario <= 8000.0f)
            {
                porcentagem = 10;
            }
            else
            {
                porcentagem = 5;
            }

            Console.WriteLine($"Novo salario = R$ {((salario * porcentagem / 100.0f) + salario).ToString("F2", CI)}");
            Console.WriteLine($"Aumento = R$ {(salario * porcentagem / 100.0f).ToString("F2", CI)}");
            Console.WriteLine($"Porcentagem = {porcentagem} %");

            Console.ReadLine();
        }
    }
}
