using System;
using System.Globalization;

namespace Exercicio_estatico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotação do dolar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double custo = ConversoDeMoeda.ValorPagar(cot, dolar);

            Console.Write("Valor a ser pago em reais = R$" + custo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
