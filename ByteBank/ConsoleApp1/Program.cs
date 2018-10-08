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
            Console.WriteLine("1 - SAQUE / 2 - DEPOSITO");
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
                default:
                    Console.WriteLine("Opção escolhida errada. Refaça a operação.");
                break;
            }


            

        }
    }
}
