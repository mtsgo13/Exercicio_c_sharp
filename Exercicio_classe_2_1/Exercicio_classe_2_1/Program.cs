using System;
using System.Globalization;

namespace Exercicio_classe_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            
            Console.WriteLine("Entre com  a largura e com  altura do retangulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("AREA = " + x.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETEO = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
