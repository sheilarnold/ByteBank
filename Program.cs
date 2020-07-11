using ByteBank.Funcionarios;
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
            int sair = 1;
            while(sair != 0)
            {
                int op;
                Console.Write("Bem vindo(a)!\n\nEscolha uma opção:\n1 - Cadastrar funcionário\n2 - Cadastrar cliente\n0 - Sair\n.:");
                op = Convert.ToInt32(Console.ReadLine());
                if(op == 1)
                {
                    Console.Write("Informe o cargo funcionário:\n1 - Administrador\n2 - Gerente\n3 - Diretor\n.:");
                    int cargo = Convert.ToInt32(Console.ReadLine());
                    switch (cargo)
                    {
                        case 1:
                            Administrador adm = new Administrador();

                            Console.Write("Informe o nome: ");
                            adm.Nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            adm.CPF = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            adm.Salario = Convert.ToDouble(Console.ReadLine());

                            adm.Bonificacao = adm.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {adm.Nome} \nCargo: Administrador\nSalário: {adm.Salario}\nBonificação: {adm.Bonificacao}\n");
                            break;
                        case 2:
                            Gerente ger = new Gerente();

                            Console.Write("Informe o nome: ");
                            ger.Nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            ger.CPF = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            ger.Salario = Convert.ToDouble(Console.ReadLine());

                            ger.Bonificacao = ger.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {ger.Nome} \nCargo: Administrador\nSalário: {ger.Salario}\nBonificação: {ger.Bonificacao}\n");
                            break;
                        case 3:
                            Diretor dir = new Diretor();

                            Console.Write("Informe o nome: ");
                            dir.Nome = Console.ReadLine();
                            Console.Write("Informe o CPF:");
                            dir.CPF = Console.ReadLine();
                            Console.Write("Informe o salário: ");
                            dir.Salario = Convert.ToDouble(Console.ReadLine());

                            dir.Bonificacao = dir.Salario;

                            Console.WriteLine($"Resumo do cadastro:\nNome: {dir.Nome} \nCargo: Administrador\nSalário: {dir.Salario}\nBonificação: {dir.Bonificacao}\n");
                            break;

                    }
                }
                else if (op == 2) {
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
                    if(op == 1)
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

            Console.WriteLine("Fim do projeto, pressione enter para finalizá-lo");
            Console.ReadLine();
        }
    }
}
