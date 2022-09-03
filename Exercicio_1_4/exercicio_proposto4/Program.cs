using System;
using System.Globalization;

namespace exercicio_proposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double valor_horas, salario;

            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor_horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor_horas;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
