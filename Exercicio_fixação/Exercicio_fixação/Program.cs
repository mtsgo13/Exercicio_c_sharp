using System;
using System.Globalization;

namespace Exercicio_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco cont;
            double saldo;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entr com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (S/N)? ");
            char depo = char.Parse(Console.ReadLine());

            if (depo == 's' || depo == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cont = new ContaBanco(numero, titular, saldo);
            }
            else
            {
                cont = new ContaBanco(numero, titular);

            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cont);

            Console.WriteLine();

            Console.Write("Entre com valor para depósito: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.Deposito(saldo);
            Console.WriteLine("Daddos da conta atualizados:");
            Console.WriteLine(cont);

            Console.WriteLine();

            Console.Write("Entre um valor para saque:");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont.Saque(saldo);
            Console.WriteLine("Daddos da conta atualizados:");
            Console.WriteLine(cont);


        }
    }
}
