using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUSCS
{
    class Gerente : Pessoa
    {
        public int CodGerente { get; set; }
        public List<Corrente> CCGerenciadas { get; set; }
        public List<Poupanca> CPGerenciadas { get; set; }


        public Gerente(string nome, string cpf, DateTime date)
        {
            Random rand = new Random();
            CodGerente = rand.Next(1, 500000);
            CCGerenciadas = new List<Corrente>();
            CPGerenciadas = new List<Poupanca>();
            Nome = nome;
            Cpf = cpf;
            DtNascimento = date;
        }

        public void AdicionarContas(Corrente conta)
        {
            CCGerenciadas.Add(new Corrente()
            {
                NumeroConta = conta.NumeroConta,
                DtAbertura = conta.DtAbertura,
                Saldo = conta.Saldo,
                Limite = conta.Limite

            });
        }
        public void AumentarLimite(int idConta, double aumentoLimite,List<Corrente>correntes)
        {
            foreach (Corrente cc in correntes)
            {
                if (cc.NumeroConta == idConta)
                {
                    cc.Limite = aumentoLimite;
                    Console.WriteLine(cc.Limite);
                    break;
                }
            }
        }

        public void MostrarContas() 
        {
            foreach (Corrente cc in CCGerenciadas)
            {
                int numeroCC = cc.NumeroConta;
                Console.WriteLine("Numero da conta:" + numeroCC);
            }
            
        }




    }
}
