using System;
using System.Globalization;

namespace Ex1
{
    internal class ContaBanco
    {
        public int Numero { get; private set; }
        public string Titular {  get; set; }
        public double Saldo {  get; private set; }

        public ContaBanco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBanco(int numero, string titular, double depositoInicial) : this(numero, titular) 
        {
            Saldo += depositoInicial;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
