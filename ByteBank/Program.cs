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
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(5000);
                Console.WriteLine(conta.Saldo);
                Metodo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exeção do tipo ArgumentExeception. ");
                Console.WriteLine(ex.ParamName);
                Console.WriteLine(ex.Message); 
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
