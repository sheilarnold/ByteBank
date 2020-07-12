using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class Autenticavel : Funcionario
    {
        private string cpf;

        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public string Senha { get; set; }

        public bool autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
