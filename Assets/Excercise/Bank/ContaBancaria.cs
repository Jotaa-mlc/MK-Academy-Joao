using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContaBancaria
{
    string nomeTitular;
    int numeroConta;
    float saldo;

    public void Deposito(float valor)
    {
        saldo += valor;
    }

    public void Saque(float valor)
    {
        saldo -= valor;
    }

    public float ConsultarSaldo()
    {
        return this.saldo;
    }

    public string ConsultarTitular()
    {
        return this.nomeTitular;
    }

    public int ConsultarNumeroConta()
    {
        return this.numeroConta;
    }

    public void PrintContaBancaria()
    {
        Debug.Log(string.Format("Nome do Titular: {0}", this.nomeTitular));
        Debug.Log(string.Format("Número da Conta: {0:D4}", this.numeroConta));
    }

    public ContaBancaria() {}

    public ContaBancaria(string _nomeTitular, int _numeroConta, float _saldo) : this()
    {
        this.nomeTitular = _nomeTitular;
        this.numeroConta = _numeroConta;
        this.saldo = _saldo;
    }
}
