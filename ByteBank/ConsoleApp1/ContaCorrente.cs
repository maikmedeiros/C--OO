﻿
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;
    
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

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    
    public bool Trasferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;        
        }
    }
}