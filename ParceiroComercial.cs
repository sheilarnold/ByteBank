using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ParceiroComercial : Autenticavel
    {
        public string Senha { get; set; }

        public bool autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
