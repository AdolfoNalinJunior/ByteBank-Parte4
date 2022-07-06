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
            catch (NullReferenceException erro) // Tratamento de erro da referência
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
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro) // Tratamento de erro de Divisão por zero
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Nào é possivel fazer divisão por 0! ");
            }
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
