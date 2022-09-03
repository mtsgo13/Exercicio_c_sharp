using System;
using System.Globalization;

namespace exeercicio_propostos2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quatd;
            double preco;
            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quatd = int.Parse(vet[1]);

            if(codigo == 1)
            {
                preco = quatd * 4.00;
            }
            else if(codigo == 2 ) {
                preco = quatd * 4.50;
            }
            else if(codigo == 3) {
                preco = quatd * 5.00;
            }
            else if(codigo == 4) { 
                preco = quatd * 2.00;
            }
            else{ 
                preco = quatd * 1.50;
            }
            Console.WriteLine("Total: R$" + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
