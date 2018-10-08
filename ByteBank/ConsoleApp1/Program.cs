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
            int escolha;

            ContaCorrente Conta1 = new ContaCorrente();

            Conta1.saldo = 150;
            Console.WriteLine("Nome do Titular:");
            Conta1.titular = Console.ReadLine();
            Console.WriteLine("Agencia:");
            Conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Conta Corrente: ");
            Conta1.conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Saldo Atual: " + Conta1.saldo);
            Console.WriteLine("1 - SAQUE / 2 - DEPOSITO / 3 - TRASFERIR");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha) {
                case 1:
                    Console.WriteLine("Valor de Saque: ");

                    //Código abaixo recebe se a função retornou verdadeiro ou falso. 
                    bool resultadoSaque = Conta1.Sacar(double.Parse(Console.ReadLine()));

                    if (resultadoSaque == false)
                    {
                        Console.WriteLine("Você não pode efetuar esse saque.");
                    }
                    else
                    {
                        Console.WriteLine("Extrado --");
                        Console.WriteLine("Nome: " + Conta1.titular);
                        Console.WriteLine("Agencia: " + Conta1.agencia);
                        Console.WriteLine("Conta: " + Conta1.conta);
                        Console.WriteLine("Novo Saldo: " + Conta1.saldo);
                    }
                break;
                case 2:
                    Console.WriteLine("Valor do Deposito: ");
                    Conta1.Depositar(double.Parse(Console.ReadLine()));

                    Console.WriteLine("Extrado --");
                    Console.WriteLine("Nome: " + Conta1.titular);
                    Console.WriteLine("Agencia: " + Conta1.agencia);
                    Console.WriteLine("Conta: " + Conta1.conta);
                    Console.WriteLine("Novo Saldo: " + Conta1.saldo);
                break;
                case 3:
                    ContaCorrente Conta2 = new ContaCorrente();
                    Conta2.titular = "Diego";
                    Conta2.saldo = 100;
                    Console.WriteLine("Titular 2: " + Conta2.titular);
                    Console.WriteLine("Saldo 2: " + Conta2.saldo);
                    Conta1.Trasferir(50, Conta2);
                    Console.WriteLine("Titular 2: " + Conta2.titular);
                    Console.WriteLine("Saldo 2: " + Conta2.saldo);
                break;
                default:
                    Console.WriteLine("Opção escolhida errada. Refaça a operação.");
                break;
            }

        }
    }
}
