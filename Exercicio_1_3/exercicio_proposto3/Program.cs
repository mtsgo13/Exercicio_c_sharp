using System;

namespace exercicio_proposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferencia;
                
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferencia = A * B - C * D;

            Console.WriteLine("Diferencia = " + diferencia);
        }
    }
}
