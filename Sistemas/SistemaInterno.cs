using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Login(Autenticavel user, string senha)
        {
            bool autenticacao = user.autenticar(senha);
            if (autenticacao)
            {
                Console.WriteLine("Bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Ops! Ocorreu algum erro ao realizar seu login, por favor, tente novamente mais tarde :)");
                return false;
            }
        }
    }
}
