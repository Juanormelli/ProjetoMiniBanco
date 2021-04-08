using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUSCS
{
    class Corrente:Conta
    {
        public double Limite { get; set; }


        public Corrente()
        {
            Limite = 0;
        }

        public string ExibirDados()
        {
            return "Numero Conta:" + NumeroConta + " Data de Abertura: " + DtAbertura + " Limite: R$ " + Limite + " Status: " + Status; ;
        }
    }
}
