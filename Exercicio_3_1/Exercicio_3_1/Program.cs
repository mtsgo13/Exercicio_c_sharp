using System;

namespace Exercicio_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Degite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha ínvalida!");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}
