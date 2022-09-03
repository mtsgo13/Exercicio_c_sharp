using System;
using System.Globalization;

namespace Exercicio_classe_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a1.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a1.NotaFinal().ToString("F2" , CultureInfo.InvariantCulture));

            if (a1.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + (" Pontos."));
            }
            

            
        }
    }
}
