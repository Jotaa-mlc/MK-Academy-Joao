using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStreet : MonoBehaviour
{

    Banco banco = new();
    // Start is called before the first frame update
    void Start()
    {
        banco.CriarContaBancaria("Antônio", 1, 25000.50f);
        banco.CriarContaBancaria("Antônio", 2, 12000f);
        banco.CriarContaBancaria("Benício", 3, 10000.50f);

        List<ContaBancaria> resultByNome = banco.EncontrarContaByNomeTitular("Antônio");
        print("Resultado pesquisa por nome:");
        foreach (var conta in resultByNome)
        {
            conta.PrintContaBancaria();
        }

        ContaBancaria resultByNumero = banco.EncontrarContaByNumeroConta(3);
        print("Resultado pesquisa por Número da conta");
        resultByNumero.PrintContaBancaria() ;

        banco.Transferencia(banco.EncontrarContaByNumeroConta(1), banco.EncontrarContaByNumeroConta(3), 15000);

        banco.Transferencia(banco.EncontrarContaByNumeroConta(1), banco.EncontrarContaByNumeroConta(3), 15000);

    }
}
