using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroAgencia = "0001";
            Conta.NumeroDaContaSequencial++;
            this.Movimetacoes = new List<Extrato>();
        }

        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimetacoes;


        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimetacoes.Add(new Extrato(dataAtual, "Deposito" , valor));
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (valor > this.ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimetacoes.Add(new Extrato(dataAtual, "Saque", -valor));


            this.Saldo -= valor;
            return true;
        }

        public string GetCodigoDaAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetCodigoDaConta()
        {
            return this.NumeroConta;
        }

        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public List<Extrato> Extrato()
        {
            return this.Movimetacoes;
        }
    }
}
