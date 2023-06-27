using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContaBancaria
    {

        private static readonly CultureInfo locale = CultureInfo.InvariantCulture;

        public int Numero { get; private set; }
        public string? Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string? titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string? titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo R$ {Saldo.ToString("F2", locale)} ";
        }

    }
}
