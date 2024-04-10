using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStreet : MonoBehaviour
{

    Banco banco = new();
    // Start is called before the first frame update
    void Start()
    {
        banco.CriarContaBancaria("Ant�nio", 1, 25000.50f);
        banco.CriarContaBancaria("Ant�nio", 2, 12000f);
        banco.CriarContaBancaria("Ben�cio", 3, 10000.50f);

        List<ContaBancaria> resultByNome = banco.EncontrarContaByNomeTitular("Ant�nio");
        print("Resultado pesquisa por nome:");
        foreach (var conta in resultByNome)
        {
            conta.PrintContaBancaria();
        }

        ContaBancaria resultByNumero = banco.EncontrarContaByNumeroConta(3);
        print("Resultado pesquisa por N�mero da conta");
        resultByNumero.PrintContaBancaria() ;

        banco.Transferencia(banco.EncontrarContaByNumeroConta(1), banco.EncontrarContaByNumeroConta(3), 15000);

        banco.Transferencia(banco.EncontrarContaByNumeroConta(1), banco.EncontrarContaByNumeroConta(3), 15000);

    }
}
