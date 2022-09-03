using System;
using System.Globalization;

namespace Exercicio_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão ímpossivel!");
                }
                else
                {
                    float resultado = (float)a / b;
                    Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
