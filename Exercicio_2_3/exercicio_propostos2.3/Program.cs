using System;

namespace exercicio_propostos2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
            {   
                Console.WriteLine("São multiplos.");
            }
            else
            {
                Console.WriteLine("Não são multiplos.");
            }
        }
    }
}
