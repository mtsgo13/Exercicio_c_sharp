using System;
using System.Globalization;

namespace exercicio_proposta2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;

           x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x < 0.00 || x> 100.00)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if(x <= 25.0)
            {
                Console.WriteLine("Intervalo: [0,25]");
            }
            else if(x <= 50.0)
            {
                Console.WriteLine("Intervalo: [25,50]");
            }
            else if(x <= 75.0)
            {
                Console.WriteLine("Intervalo: [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo: [75,100]");
            }
        }
    }
}
