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
                Metodo();
            }
            catch (DivideByZeroException) // Tratamento mais expecifico
            {
                Console.WriteLine("Nâo é possível realizar divisâo por zero. ");
            }
            catch (Exception erro) // Tratamento mais generaizado
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine(erro.Message);
                Console.WriteLine("Aconteceu um erro!! ");
            }
          

        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            // Erro de referência
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
