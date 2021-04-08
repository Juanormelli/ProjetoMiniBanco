using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUSCS
{
    class Cliente:Pessoa
    {
        public int CodCliente { get; private set; }
        public Corrente contaCorrente { get; set; }
        public Poupanca contaPoupanca { get; set; }


        public Cliente(string nome,string cpf, DateTime dtnascimento, Corrente corrente )
        {
            Random rand = new Random();
            CodCliente = rand.Next(1, 50000);
            this.Nome = nome;
            this.Cpf = cpf;
            this.DtNascimento = dtnascimento;
            this.contaCorrente = corrente;
            
            


        }
        public Cliente(string nome, string cpf, DateTime dtnascimento, Poupanca poupanca)
        {
            Random rand = new Random();
            CodCliente = rand.Next(1, 50000);
            this.Nome = nome;
            this.Cpf = cpf;
            this.DtNascimento = dtnascimento;
            this.contaPoupanca = contaPoupanca;



        }

    }
}
