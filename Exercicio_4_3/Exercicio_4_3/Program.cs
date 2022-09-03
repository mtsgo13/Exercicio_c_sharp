using System;
using System.Globalization;

namespace Exercicio_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
                float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
                float c = float.Parse(vet[2], CultureInfo.InvariantCulture);

                float media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
