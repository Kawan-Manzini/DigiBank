using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public  class Extrato
    {
        public Extrato(DateTime data, string Descricao, double valor)
        {
            this.Data = data;
            this.Descricao = Descricao;
            this.Valor = valor;
        }

        public DateTime Data { get; private set; }
        public string Descricao { get; set; }
        public double Valor { get; private set; }

    }
}
