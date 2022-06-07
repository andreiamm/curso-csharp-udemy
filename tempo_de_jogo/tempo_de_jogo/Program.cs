using System;

namespace tempo_de_jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duracao;
            
            Console.Write("Hora inicial: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            int fim = int.Parse(Console.ReadLine());

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            Console.ReadLine();
        }
    }
}
