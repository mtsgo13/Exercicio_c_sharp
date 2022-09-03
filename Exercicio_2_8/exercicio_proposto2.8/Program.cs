using System;
using System.Globalization;

namespace exercicio_proposto2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto =  0;
            
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else if (salario > 4500)
            {
                imposto = (salario - 4500) * 0.028 + 1500 * 0.18 + 1000 * 0.08;
            }
            if (imposto == 0.0)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                Console.WriteLine("R$: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            

        }
    }
}   
