using System;
using System.Globalization;

namespace Exercicio_classe_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f1);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(por);

            Console.WriteLine("Dados atualizados: " + f1);

        }
    }
}
