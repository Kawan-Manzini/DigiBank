﻿using DigiBank.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Contratos
{
    public interface IConta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        double ConsultaSaldo();
        string GetCodigoDoBanco();
        string GetCodigoDaAgencia();
        string GetCodigoDaConta();

        List<Extrato> Extrato();
    }
}
