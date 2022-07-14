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

        public double Saldo { get ; }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia < 0)
            {
                throw new ArgumentException("O argumento Agencia deve ser maior que 0", nameof(agencia));
            }
            else if (numero < 0)
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
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque: " + nameof(valor));
            }

            else if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
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


        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para tranferência: " + nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
