using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv4Q43 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double graosArroz = 1;
        double graosCasaAnterior = 1;

        for (double i = 2; i <= 8; i++)
        {
            double quantidadeCasas = (i * 2) - 1;
            graosCasaAnterior *= 2;

            graosArroz += graosCasaAnterior * quantidadeCasas;
        }

        print(graosArroz);
    }
}