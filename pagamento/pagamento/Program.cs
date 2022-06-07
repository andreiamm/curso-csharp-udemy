using System;
using System.Globalization;

namespace pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            float valorHora = float.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine($"O pagamento para {nome} deve ser de R$ {(valorHora * horasTrabalhadas).ToString("F2", CI)}");

            Console.ReadLine();
        }
    }
}
