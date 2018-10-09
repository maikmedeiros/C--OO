using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            // UMA MANEIRA
            //Cliente cliente1 = new Cliente();
            //cliente1.nome = "Maik";
            //cliente1.cpf = "132";
            //cliente1.profissao = "321";

            //ContaCorrente conta1 = new ContaCorrente();
            ////OBS UMA CLASSE DEVE RECEBER A OUTRA PARA PODER ACESSAR SEUS METODOS - CÓDIGO DA LINHA ABAIXO.
            //conta1.titular = cliente1;
            //conta1.titular.nome = "Maaaik";

            //Console.WriteLine(cliente1.nome);
            //Console.WriteLine(conta1.titular.nome);


            //SEGUNDA MANEIRA

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = new Cliente();
            conta2.titular.nome = "Maik";

            Console.WriteLine(conta2.titular.nome);
        }
    }
}
