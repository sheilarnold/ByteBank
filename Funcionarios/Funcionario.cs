using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int totalFuncionarios { get; private set; }
        public string Nome { get; set; }

        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        private double bonificacao;

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            totalFuncionarios++;
        }
        public virtual double Bonificacao
        {
            get
            {
                return bonificacao;
            }
            set
            {
                this.bonificacao = value * 0.20;
            }
        }

        public virtual void aumento()
        {
            Salario += (Salario * 0.1);
        }

    }
}
