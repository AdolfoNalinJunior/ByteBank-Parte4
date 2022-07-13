// using _05_ByteBank;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double  TotalOperacao { get; set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        public int Agencia { get; }
        
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento Agencia deve ser maior que 0", nameof(agencia));
            }
            else if (numero <= 0)
            {
                throw new ArgumentException("O argumento Número deve ser miaor que 0.", nameof(numero));
            }

            this.Agencia = agencia;
            this.Numero = numero;

            TotalDeContasCriadas++;
            TotalOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor " + valor);
            }
            else
            {
               _saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {

            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
