using System;

namespace Exercicio_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique dois pontos: ");

            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                Console.Write("Digite mais dois pontos: ");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);


            }


        }
    }
}
