using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Gerente: Funcionario
    {
        private double bonificacao;
        public override double Bonificacao
        {
            get
            {
                return bonificacao;
            }
            set
            {
                bonificacao = value * 0.20;
            }
        }
    }
}
