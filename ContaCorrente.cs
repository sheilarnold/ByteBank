using ByteBank.Excecoes;
using System;

namespace ByteBank {
    public class ContaCorrente
    {
        private Cliente titular;
        private int agencia;
        private int conta;
        private double saldo;

        //apenas o set é privado
        public static int totalContas { get; private set; }

        public static double taxaOperacao { get; private set; }

        public int Conta { get; }
        public ContaCorrente(int agencia, int conta)
        {
            if(agencia <= 0)
            {
                ArgumentException e = new ArgumentException("Agencia informada não atende à regra básica de configuração: ser maio ou igual à 1.");
                throw e;
            }
            else if (conta <= 0)
            {
                ArgumentException e = new ArgumentException("Número informado não atende à regra básica de configuração: ser maior ou igual à 1.");
                throw e;
            }
            else
            {
                Agencia = agencia;
                Conta = conta;
                taxaOperacao = 30 / totalContas;
                totalContas++;
            }

        }

        public Cliente Titular { get; set; }

        public int Agencia { get; }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                saldo = value;
            }
        }

        public void Saque(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }
            if(valor > this.saldo || valor <= 0)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                this.saldo -= valor;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }
            if (valor > 0 || valor <= 0) 
            { 
                this.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para tranferência.", nameof(valor));
            }
            Saque(valor);
            conta.Depositar(valor);
        }
    }
}