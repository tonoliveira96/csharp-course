using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class ContaBancaria
    {

        public int Numero {  get; private set; }
        public string Titular{ get; set; }
        public double Saldo { get; private set; }
        private int TaxaSaque = 5;

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoinciial): this(numero, titular)
        {
            Deposito(depositoinciial);
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + TaxaSaque;
        }

        public override string ToString()
        {
            return " - Conta: "
                + Numero
                + "\n - Títular: "
                + Titular
                + "\n - Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
