using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Excecoes
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double Saque { get; }
        public SaldoInsuficienteException(string msg) : base(msg)
        {

        }

        public SaldoInsuficienteException(double saldo, double saque) : this("Saldo insuficiente para saque de R$: " + saque + "\n  Saldo atual: " + saldo)
        {
            Saldo = saldo;
            Saque = saque;
        }

        public SaldoInsuficienteException()
        {

        }
    }
}
