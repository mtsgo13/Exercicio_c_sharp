using System;

namespace Exercicio_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for( int i = 1; i <= n; i++)
            {
                int linha = i;
                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{linha} {quadrado} {cubo}");
            }
        }
    }
}
