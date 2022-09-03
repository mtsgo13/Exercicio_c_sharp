using System;


namespace Exercicio_estatico_1
{
    class ConversoDeMoeda
    {
        public static double IOF = 0.06;

        public static double ValorPagar( double cot, double dolar)
        {
            return cot * dolar + (cot * dolar * IOF);
        }
    }
}
