﻿using System;

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

        public ContaCorrente(int agencia, int conta)
        {
            try
            {
                Agencia = agencia;
                Conta = conta;
                taxaOperacao = 30 / totalContas;
                totalContas += 1;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro ao registrar nova conta, favor, tente novamente mais tarde.");
            }

        }

        public Cliente Titular { get; set; }

        public int Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                agencia = value;
            }
        }

        public int Conta
        {
            get
            {
                return conta;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                conta = value;
            }
        }

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
                
        public bool Saque(double valor)
        {
            if(valor > this.saldo || valor <= 0)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
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

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if(valor > this.saldo || valor <= 0)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return Depositar(valor);
            }
        }
    }
}