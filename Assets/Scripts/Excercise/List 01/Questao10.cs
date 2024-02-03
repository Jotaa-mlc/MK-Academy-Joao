using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questao10 : MonoBehaviour
{
    public float[] lados = new float[3];
    // Start is called before the first frame update
    void Start()
    {
        int ladosIguais = 0;

        for (int i = 1; i < lados.Length; i++)
        {
            if (lados[i-1] == lados[i])
                ladosIguais++;
        }

        if (lados[0] == lados[lados.Length - 1])
            ladosIguais++;

        switch (ladosIguais) 
        {
            case 0:
                print("ESCALENO!");
                break;
            case 1:
                print("ISÓCELES!");
                break;
            case 3:
                print("EQUILÁTERO!");
                break;
        }
    }
}
