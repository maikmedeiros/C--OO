using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta1 = new ContaCorrente();

            Console.WriteLine("Nome do Titular:");
            Conta1.titular = Console.ReadLine();
            Console.WriteLine("Agencia:");
            Conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Conta Corrente: ");
            Conta1.conta = int.Parse(Console.ReadLine());
            Conta1.saldo = 100.00;

            if (Conta1.saldo >= 0)
            {
                Console.WriteLine("Saldo de " + Conta1.saldo);
            }
            else
            {
                Console.WriteLine("Você esta em cheque especial - Saldo: " + Conta1.saldo);
            }
        }
    }
}
