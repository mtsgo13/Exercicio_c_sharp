using System;
using System.Globalization;

namespace Exercicio_fixação
{
    class ContaBanco
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }



        public ContaBanco()
        {
            Saldo = 0;
        }
        public ContaBanco(int numero, string titular) : this()
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBanco(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;

        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
         public void Saque(double saldo)
        {
            Saldo = (Saldo - saldo) - 5;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
