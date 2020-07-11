using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Gerente: Funcionario
    {
        public override double Bonificacao
        {
            get
            {
                return base.Bonificacao;
            }
            set
            {
                base.Bonificacao = value * 0.20;
            }
        }
    }
}
