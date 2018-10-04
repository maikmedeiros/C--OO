using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta1 = new ContaCorrente();

            Conta1.titular = "Gabriela";
            Conta1.agencia = 123;
            Conta1.conta = 123456;
            Conta1.saldo = 0;

            ContaCorrente Conta2 = new ContaCorrente();

            Conta2.titular = "Gabriela";
            Conta2.agencia = 123;
            Conta2.conta = 123456;
            Conta2.saldo = 0;

            Console.WriteLine(Conta1 == Conta2);
            Conta2 = Conta1;
            Console.WriteLine(Conta1 == Conta2);
            Console.ReadLine();

        }
    }
}
