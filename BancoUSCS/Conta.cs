using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUSCS
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public DateTime DtAbertura { get; set; }
        public double Saldo { get; set; }
        public string Status { get;}


        public Conta()
        {
            Random rand = new Random();
            this.NumeroConta = rand.Next(1, 500000);
            this.DtAbertura = DateTime.Now;
            this.Saldo = 0;
            this.Status = "Aberta";


        }

        public double VerificarSaldo()
        {
            return Saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;

        }
        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia; 
        } 
        


    }
}
