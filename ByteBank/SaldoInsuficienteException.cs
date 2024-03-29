﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativade de sque do valor de " + valorSaque + " em uma conta de saldo " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
