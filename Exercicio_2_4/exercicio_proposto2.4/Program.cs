using System;

namespace exercicio_proposto2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, duracao;

            string[] vet = (Console.ReadLine().Split(' '));
            hora_inicial = int.Parse(vet[0]);
            hora_final = int.Parse(vet[1]);

            if(hora_inicial < hora_final)
            {
                duracao = hora_final - hora_inicial;
            }
            else
            {
                duracao = 24 - hora_inicial + hora_final;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + ("HORA(S)"));
        }
    }
}
