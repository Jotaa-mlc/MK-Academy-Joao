using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETC : MonoBehaviour
{
    int[/*Linhas*/,/*Colunas*/] matrix = new int[2, 3];

    void Start()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = Random.Range(0, 100);
                print($"Linha {row + 1} Coluna {column + 1}: {matrix[row, column]}");
            }
        }
    }
}
