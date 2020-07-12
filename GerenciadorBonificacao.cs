using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += getBonificacao();
        }

        public double getBonificacao()
        {
            return totalBonificacao;
        }
    }
}
