using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // SisByteBank();
            try
            {
                ContaCorrente c1 = new ContaCorrente(0, 0);                
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("Fim do projeto, pressione enter para finalizá-lo");
            Console.ReadLine();
        }

        public static void SisByteBank()
        {
            SistemaInterno sis = new SistemaInterno();

            Diretor dir = new Diretor("111.212.363.90", 5000);

            dir.Nome = "Camila Fernandez";
            dir.Senha = "123";

            sis.Login(dir, dir.Senha);

            ParceiroComercial par = new ParceiroComercial();
            par.Senha = "321";

            sis.Login(par, par.Senha);
        }

        public static void Menu()
        {
            int sair = 1;
            while (sair != 0)
            {
                int op;
                Console.Write("Bem vindo(a)!\n\nEscolha uma opção:\n1 - Cadastrar funcionário\n2 - Cadastrar cliente\n0 - Sair\n.:");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.Write("Informe o cargo funcionário:\n1 - Administrador\n2 - Gerente\n3 - Diretor\n.:");
                    int cargo = Convert.ToInt32(Console.ReadLine());
                    switch (cargo)
                    {
                        case 1:
                            Console.Write("Informe o nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            string cpf = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            double salario = Convert.ToDouble(Console.ReadLine());

                            Administrador adm = new Administrador(cpf, salario);
                            adm.Nome = nome;
                            adm.Bonificacao = adm.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {adm.Nome} \nCargo: Administrador\nSalário: {adm.Salario}\nBonificação: {adm.Bonificacao}\n");
                            break;
                        case 2:
                            Console.Write("Informe o nome: ");
                            nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            cpf = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());

                            Gerente ger = new Gerente(cpf, salario);
                            ger.Nome = nome;
                            ger.Bonificacao = ger.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {ger.Nome} \nCargo: Administrador\nSalário: {ger.Salario}\nBonificação: {ger.Bonificacao}\n");
                            break;
                        case 3:
                            Console.Write("Informe o nome: ");
                            nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            cpf = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());

                            Diretor dir = new Diretor(cpf, salario);
                            dir.Nome = nome;
                            dir.Bonificacao = dir.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {dir.Nome} \nCargo: Administrador\nSalário: {dir.Salario}\nBonificação: {dir.Bonificacao}\n");
                            break;

                    }
                }
                else if (op == 2)
                {
                    Console.Write("Informe a agência: ");
                    int agencia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe a conta: ");
                    int conta = Convert.ToInt32(Console.ReadLine());

                    ContaCorrente c = new ContaCorrente(agencia, conta);
                    Cliente cli = new Cliente();

                    Console.Write("Informe o nome: ");
                    cli.Nome = Console.ReadLine();
                    Console.Write("Informe o CPF: ");
                    cli.CPF = Console.ReadLine();
                    Console.Write("Informe a profissão: ");
                    cli.Profissao = Console.ReadLine();

                    c.Titular = cli;

                    Console.Write("Deseja fazer um depósito?\n0 - Não\n1 - Sim\n.:");
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Informe o valor para depósito: ");
                        c.Depositar(Convert.ToDouble(Console.ReadLine()));
                    }
                    Console.WriteLine($"Resumo do cadastro:\nNome: {cli.Nome} \nProfissão: {cli.Profissao}\nAgência: {c.Agencia}\nConta: {c.Conta}\nSaldo: {c.Saldo}");

                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
                Console.Write("Deseja sair do sistema?\n0 - Sim\n1 - Não\n.:");
                sair = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
