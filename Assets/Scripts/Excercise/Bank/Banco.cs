using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco
{
    List<ContaBancaria> _contasBancarias = new List<ContaBancaria>();

    public void CriarContaBancaria(string _nomeTitular, int _numeroConta, float _saldo)
    {
        ContaBancaria conta = new(_nomeTitular,_numeroConta, _saldo);
        _contasBancarias.Add(conta);
        Debug.Log("Conta Criada");
        conta.PrintContaBancaria();
    }

    public List<ContaBancaria> EncontrarContaByNomeTitular(string nomeTitular)
    {
        List<ContaBancaria> result = new List<ContaBancaria>();

        foreach (var conta in _contasBancarias)
        {
            if(conta.ConsultarTitular() == nomeTitular)
            {
                result.Add(conta);
            }
        }

        return result;
    }

    public ContaBancaria EncontrarContaByNumeroConta(int numeroConta) 
    { 
        ContaBancaria result = new();

        foreach (var conta in _contasBancarias)
        {
            if (conta.ConsultarNumeroConta() == numeroConta)
            {
                result = conta;
                break;
            }
        }

        return result;
    }

    public void Transferencia(ContaBancaria remetente, ContaBancaria destinatario, float valor)
    {
        if(remetente.ConsultarSaldo() >= valor)
        {
            remetente.Saque(valor);
            destinatario.Deposito(valor);

            string msg = string.Format(
                "Transferência para {0} (conta - {1}) no valor de {2} realizada com sucesso.\n Saldo restante na conta {4} : R$ {5}",
                destinatario.ConsultarTitular(), destinatario.ConsultarNumeroConta(), valor, remetente.ConsultarNumeroConta(), remetente.ConsultarSaldo());
            Debug.Log(msg);
        }
        else
        {
            Debug.Log("Valor de Saldo insuficiente para completar a transação.");
        }
    }
}
