using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        private double bonificacao;
        public virtual double Bonificacao
        {
            get
            {
                return bonificacao;
            }
            set
            {
                this.bonificacao = value * 0.10;
            }
        }
        
    }
}
