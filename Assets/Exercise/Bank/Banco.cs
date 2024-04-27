using System.Collections.Generic;
using UnityEngine;

public class Banco
{
    List<ContaBancaria> _contasBancarias = new List<ContaBancaria>();

    public void CriarContaBancaria(string _nomeTitular, int _numeroConta, float _saldo)
    {
        ContaBancaria conta = new(_nomeTitular, _numeroConta, _saldo);
        _contasBancarias.Add(conta);
        Debug.Log("Conta Criada");
        conta.PrintContaBancaria();
    }

    public List<ContaBancaria> EncontrarContaByNomeTitular(string nomeTitular)
    {
        List<ContaBancaria> result = new List<ContaBancaria>();

        foreach (var conta in _contasBancarias)
        {
            if (conta.ConsultarTitular().Contains(nomeTitular))
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
        if (remetente.ConsultarSaldo() >= valor)
        {
            remetente.Saque(valor);
            destinatario.Deposito(valor);

            string msg = string.Format(
                "Transferência de {0} (conta - {1}) para {3} (conta - {4}) no valor de {5} realizada com sucesso.\n Saldo restante na conta: R$ {2}",
                remetente.ConsultarTitular(), remetente.ConsultarNumeroConta(), remetente.ConsultarSaldo(),
                destinatario.ConsultarTitular(), destinatario.ConsultarNumeroConta(), valor);
            Debug.Log(msg);
        }
        else
        {
            Debug.Log("Valor de Saldo insuficiente para completar a transação.");
        }
    }
}
