using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUSCS
{
    class Poupanca:Conta
    {

        public string ExibirDados()
        {
            return "Numero Conta:" + NumeroConta + " Data de Abertura: " + DtAbertura + " Status: " + Status; ;
        }
        public double PrevisaoGanho(double juros, double quantia,int meses)
        {
            double previsao = 0;
            juros = (juros / 100)/meses;
            return previsao = quantia + ((quantia * juros )* meses);
        }
    }
}
