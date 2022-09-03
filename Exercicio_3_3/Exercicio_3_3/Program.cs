using System;

namespace Exercicio_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int disel = 0;

            Console.WriteLine("1.Gasolina 2.Alcool 3.Disel 4.Sair");
            int cod = int.Parse(Console.ReadLine());

            while(cod != 4)
            {
                if(cod == 1)
                {
                    gasolina++;
                }
                else if (cod == 2)
                {
                    alcool++;
                }
                else if (cod == 3)
                {
                    disel++;
                }
                else
                {
                    Console.WriteLine("Numero invalido, digite novamente!");
                }
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!!");
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Disel: " + disel);
        }
    }
}
