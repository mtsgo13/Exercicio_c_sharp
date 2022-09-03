using System;
using System.Globalization;

namespace exercicio_proposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            double  A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2;
            CIRCULO = 3.14159 * C * C;
            TRAPEZIO = (A + B) / 2 * C;
            QUADRADO = B * B;
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO:" + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO:" + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO:" + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO:" + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO:" + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
