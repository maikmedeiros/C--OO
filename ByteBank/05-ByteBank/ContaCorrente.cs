namespace _05_ByteBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        public double saldo;

        //FUNÇÃO SACAR
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }

        }
        //FUNÇÃO DEPOSITAR
        public void Depositar(double valorDepositar)
        {
            this.saldo += valorDepositar;
        }
        //FUNÇÃO TRASNFERIR
        public bool Trasferir(double valorTrasferir, ContaCorrente contaDestino)
        {
            if (this.saldo < valorTrasferir)
            {
                return false;
            }
            else
            {
                this.saldo -= valorTrasferir;
                contaDestino.Depositar(valorTrasferir);
                return true;
            }
        }
    }
}