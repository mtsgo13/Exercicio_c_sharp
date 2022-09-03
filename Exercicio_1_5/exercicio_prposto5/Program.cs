using System;
using System.Globalization;

namespace exercicio_prposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, peca1, peca2;
            double preco1, preco2, total;

            string[] vet = Console.ReadLine().Split(' ');

            peca1 = int.Parse(vet[0]);
            num1 = int.Parse(vet[1]);
            preco1 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            preco2 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            total = preco1 * num1 + preco2 * num2;

            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
