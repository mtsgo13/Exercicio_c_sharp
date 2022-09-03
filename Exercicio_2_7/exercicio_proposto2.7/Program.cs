using System;
using System.Globalization;

namespace exercicio_proposto2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            float x = float.Parse(vet[0], CultureInfo.InvariantCulture);
          float y = float.Parse(vet[1], CultureInfo.InvariantCulture);

            if(x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem.");
            }
            else if(x == 0.0)
            {
                Console.WriteLine("EIXO Y");
            }
            else if(y == 0.0)
            {
                Console.WriteLine("EIXO X");
            }
            else if(x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
