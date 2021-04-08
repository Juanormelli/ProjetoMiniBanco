using System;
using System.Collections.Generic;

namespace BancoUSCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string button = "";
            List<Corrente> corrente = new List<Corrente>();
            List<Cliente> cliente = new List<Cliente>();
            List<Poupanca> poupanca = new List<Poupanca>();
            List<Gerente> gerente = new List<Gerente>();

            while (button != "E")
            {

                Console.WriteLine("Deseja executar qual ação ?");
                Console.WriteLine(" 1-Cliente  ------------------  2-Gerente ");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    Console.WriteLine("Ja é Cliente ? S ou N");
                    string jacliente = Console.ReadLine().ToUpper();
                    if (jacliente == "S")
                    {
                        Console.WriteLine("Qual tipo de conta quer visualizar?CC ou CP ");
                        string tipoconta = Console.ReadLine().ToUpper();
                        if (tipoconta == "CC")
                        {
                            Console.WriteLine("Qual Numero de sua conta ?");
                            int NumCC = int.Parse(Console.ReadLine());
                            foreach (Corrente cc in corrente)
                            {
                                if (cc.NumeroConta == NumCC)
                                {
                                    string cond = "";
                                    while (cond != "E")
                                    {
                                        Console.WriteLine("Qual ação deseja fazer ? S-Saldo D-Deposito SS-Saque ED-ExibirDados");
                                        string acao = Console.ReadLine().ToUpper();
                                        if (acao == "S")
                                        {
                                            Console.WriteLine("R$ " + cc.VerificarSaldo());
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "D")
                                        {
                                            Console.WriteLine("Valor que deseja depositar? ");
                                            double quantia = double.Parse(Console.ReadLine());
                                            cc.Deposito(quantia);
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "SS")
                                        {
                                            Console.WriteLine("Valor que deseja Sacar? ");
                                            double quantia = double.Parse(Console.ReadLine());
                                            cc.Saque(quantia);
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "ED")
                                        {
                                            Console.WriteLine(cc.ExibirDados());
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else
                                        {
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                    }
                                }
                            }
                        }
                        if (tipoconta == "CP")
                        {
                            Console.WriteLine("Qual Numero de sua conta ?");
                            int NumCP = int.Parse(Console.ReadLine());
                            foreach (Poupanca cp in poupanca)
                            {
                                if (cp.NumeroConta == NumCP)
                                {
                                    string cond = "";
                                    while (cond != "E")
                                    {
                                        Console.WriteLine("Qual ação deseja fazer ? S-Saldo D-Deposito SS-Saque ED-ExibirDados PL - Previsao De Lucros");
                                        string acao = Console.ReadLine().ToUpper();
                                        if (acao == "S")
                                        {
                                            Console.WriteLine("R$ " + cp.VerificarSaldo());
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "D")
                                        {
                                            Console.WriteLine("Valor que deseja depositar? ");
                                            double quantia = double.Parse(Console.ReadLine());
                                            cp.Deposito(quantia);
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "SS")
                                        {
                                            Console.WriteLine("Valor que deseja Sacar? ");
                                            double quantia = double.Parse(Console.ReadLine());
                                            cp.Saque(quantia);
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if (acao == "ED")
                                        {
                                            Console.WriteLine(cp.ExibirDados());
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                        else if(acao == "PL")
                                        {
                                            Console.WriteLine("Juros Hoje ? Em porcentagem Anual");
                                            double juros = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Quantia ?");
                                            double quantia = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Meses que pretende deixar investido");
                                            int meses = int.Parse(Console.ReadLine());
                                            double lucro = cp.PrevisaoGanho(juros,quantia,meses);
                                            Console.WriteLine("R$ " + lucro);
                                            Console.WriteLine("Deseja Encerrar sessao? E- para encerrar  ");
                                            cond = Console.ReadLine().ToUpper();

                                        }
                                    }
                                }
                            }


                        }
                    }
                    else if (jacliente == "N")
                    {
                        Console.WriteLine("Deseja cadastrar qual tipo de conta ?CC Conta Corrente ------ CP conta poupança");
                        string tipodeConta = Console.ReadLine().ToUpper();
                        if (tipodeConta == "CC")
                        {
                            Console.WriteLine("Nome");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Cpf:");
                            string Cpf = Console.ReadLine();
                            Console.WriteLine("Data de nascimento");
                            string date = Console.ReadLine();
                            DateTime dt = DateTime.Parse(date);
                            Corrente cc = new Corrente();

                            corrente.Add(cc);

                            cliente.Add(new Cliente(nome, Cpf, dt, cc)
                            {
                                Nome = nome,
                                Cpf = Cpf,
                                DtNascimento = dt,


                            });
                            Console.WriteLine("O numero da conta é : " + cc.NumeroConta);
                        }
                        if (tipodeConta == "CP")
                        {
                            Console.WriteLine("Nome");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Cpf:");
                            string Cpf = Console.ReadLine();
                            Console.WriteLine("Data de nascimento");
                            string date = Console.ReadLine();
                            DateTime dt = DateTime.Parse(date);
                            Poupanca cp = new Poupanca();
                            poupanca.Add(cp);
                            cliente.Add(new Cliente(nome, Cpf, dt,cp )
                            {
                                Nome = nome,
                                Cpf = Cpf,
                                DtNascimento = dt,


                            });
                            Console.WriteLine("O numero da conta é : " + cp.NumeroConta);
                        }
                    }
                }
                else if (menu == "2")
                {
                    Console.WriteLine("Deseja Executar qual ação ?");
                    Console.WriteLine("1- Cadastrar Gerente ------------------ 2-Gerenciar contas ?");

                    string acaogerente = Console.ReadLine();

                    if (acaogerente == "1")
                    {
                        Console.WriteLine("Cadastro de gerente");
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();

                        Console.Write("CPF:");
                        string cpf = Console.ReadLine();

                        Console.Write("Data de nascimento: ");
                        string date = Console.ReadLine();
                        DateTime dtn = DateTime.Parse(date);


                        gerente.Add(new Gerente(nome, cpf, dtn)
                        {
                            Nome = nome,
                            Cpf = cpf,
                            DtNascimento = dtn,


                        });

                        Console.WriteLine("Gerente cadastrado, Codigo dele é:");
                        foreach (Gerente gg in gerente)
                        {
                            if (gerente.IndexOf(gg) == gerente.Count - 1)
                            {
                                Console.WriteLine(gg.CodGerente);
                            }
                        }
                        Console.WriteLine("Deseja Entrar no Gerenciamento de contas ? S ou N");
                        string decisao = Console.ReadLine().ToUpper();

                        if (decisao == "S")
                        {
                            Console.WriteLine("Digite seu codigo: ");
                            int Cg = int.Parse(Console.ReadLine());
                            foreach (Gerente g in gerente)
                            {
                                if (Cg == g.CodGerente)
                                {
                                    Console.WriteLine("1 - Vincular conta ao gerente -------------- 2 - Gerenciar Limite de contas  ");
                                    string menugerente = Console.ReadLine();
                                    if (menugerente == "1")
                                    {
                                        Console.WriteLine("Qual tipo de conta deseja cadastrar ? CC=Conta corrente ou CP=conta poupança");
                                        string tipodeconta = Console.ReadLine().ToUpper();
                                        if (tipodeconta == "CC")
                                        {
                                            Console.WriteLine("Digite o numero da conta que deseja adicionar ao Gerente ");
                                            int numConta = int.Parse(Console.ReadLine());
                                            foreach (Corrente cc in corrente)
                                            {
                                                if (cc.NumeroConta == numConta)
                                                {
                                                    g.AdicionarContas(cc);


                                                    Console.WriteLine("As contasgerenciadas Sao:");
                                                    g.MostrarContas();

                                                }
                                            }



                                        }
                                    }
                                    if (menugerente == "2")
                                    {
                                        Console.WriteLine("Deseja Aumentar o Limite de alguma conta ? S ou N ");
                                        decisao = Console.ReadLine().ToUpper();
                                        if (decisao == "S")
                                        {
                                            Console.WriteLine("Numero da Conta");
                                            int conta = int.Parse(Console.ReadLine());
                                            foreach (Corrente cc in corrente)
                                            {
                                                if (cc.NumeroConta == conta)
                                                {
                                                    Console.WriteLine("Novo Limite");
                                                    double limite = int.Parse(Console.ReadLine());
                                                    g.AumentarLimite(conta, limite, corrente);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nenhuma conta encontrada!!");
                                                }
                                            }

                                        }
                                        Console.WriteLine("Deseja continuar?");
                                        button = Console.ReadLine().ToUpper();
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nao Existe ninguem cadastrado com este codigo!!");
                        }

                    }
                    if (acaogerente == "2")
                    {
                        Console.Write("Digite seu codigo: ");
                        int Cg = int.Parse(Console.ReadLine());
                        foreach (Gerente g in gerente)
                        {
                            if (Cg == g.CodGerente)
                            {
                                Console.WriteLine("1 - Vincular conta ao gerente -------------- 2 - Gerenciar Limite de contas  ");
                                string menugerente = Console.ReadLine();
                                if (menugerente == "1")
                                {
                                    Console.WriteLine("Qual tipo de conta deseja cadastrar ? CC=Conta corrente ou CP=conta poupança");
                                    string tipodeconta = Console.ReadLine().ToUpper();
                                    if (tipodeconta == "CC")
                                    {
                                        Console.WriteLine("Digite o numero da conta que deseja adicionar ao Gerente ");
                                        int numConta = int.Parse(Console.ReadLine());
                                        foreach (Corrente cc in corrente)
                                        {
                                            if (cc.NumeroConta == numConta)
                                            {
                                                g.AdicionarContas(cc);


                                                Console.WriteLine("As contasgerenciadas Sao:");
                                                g.MostrarContas();

                                            }
                                        }



                                    }
                                }
                                if (menugerente == "2")
                                {
                                    Console.WriteLine("Deseja Aumentar o Limite de alguma conta ? ");
                                    string decisao = Console.ReadLine().ToUpper();
                                    if (decisao == "S")
                                    {
                                        Console.WriteLine("Numero da Conta");
                                        int conta = int.Parse(Console.ReadLine());
                                        foreach (Corrente cc in corrente)
                                        {
                                            if (cc.NumeroConta == conta)
                                            {
                                                Console.WriteLine("Novo Limite");
                                                double limite = int.Parse(Console.ReadLine());
                                                g.AumentarLimite(conta, limite, corrente);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nenhuma conta encontrada!!");
                                            }
                                        }
                                    }
                                    Console.WriteLine("Deseja continuar?");
                                    button = Console.ReadLine().ToUpper();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Nao Existe ninguem cadastrado com este codigo!!");
                            }
                        }



                    }

                }
                else
                {
                    Console.WriteLine("Opção Invalida!");
                    Console.WriteLine("Deseja Tentar Novamente ? Se deseja encerar digite E");
                    button = Console.ReadLine().ToUpper();
                }
            }



        }
    }
}
