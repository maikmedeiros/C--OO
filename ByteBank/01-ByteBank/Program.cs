using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta1 = new ContaCorrente();

            Conta1.titular = "Maik Medeiros";
            Conta1.agencia = 888;
            Conta1.conta = 123456;
            Conta1.saldo = 150;

            Console.WriteLine("Nome: " + Conta1.titular);
            Console.WriteLine("Agencia: " + Conta1.agencia);
            Console.WriteLine("Conta Corrente: " + Conta1.conta);
            Conta1.saldo += 200;
            Console.WriteLine("Saldo: " + Conta1.saldo);
            Console.ReadLine();
        }
    }
}
