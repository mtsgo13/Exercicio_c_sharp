using System;
using System.Globalization;

namespace Exercicio_classe_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            f2.Salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario medio: " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
