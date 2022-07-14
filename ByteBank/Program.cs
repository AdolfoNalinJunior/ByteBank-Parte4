using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(10, 123456);
                ContaCorrente conta2 = new ContaCorrente(19, 2345);

                conta.Depositar(100);
                Console.WriteLine(conta.Saldo);
                conta.Transferir(30, conta2);
                Console.WriteLine(conta2.Saldo);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu uma exeção do tipo ArgumentExeception. ");
                Console.WriteLine("Nome do parâmetro: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException. "); 
            }
            catch (Exception) // Tratamento mais generaizado
            {
                Console.WriteLine("Aconteceu um erro!! ");
            }
          
            //catch (DivideByZeroException) // Tratamento mais expecifico
            //{
            //    Console.WriteLine("Nâo é possível realizar divisâo por zero. ");
            //}

        }

        private static void Metodo()
        {
            TestaDivisao(1);
        }

        private static void TestaDivisao(int divisor)
        {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exeção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
