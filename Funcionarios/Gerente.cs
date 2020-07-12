using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Gerente: Autenticavel
    {
        public Gerente(string cpf, double salario) : base(cpf, salario)
        {

        }
        public override double Bonificacao
        {
            get
            {
                return base.Bonificacao;
            }
            set
            {
                base.Bonificacao = value * 0.25;
            }
        }
    }
}
