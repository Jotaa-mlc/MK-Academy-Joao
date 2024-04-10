using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lv5Q47 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 10;

    Utils utils = new();
    void Start()
    {
        int[] vector = utils.VectorInit(sizeOfVector, 1, 999999);
        int value = Random.Range(1, 999999);
        int equals = 0, greater = 0, less = 0;

        foreach(int i in vector)
        {
            if(i == value)
            {
                equals++;
            }
            else if(i > value) 
            {
                greater++;
            }
            else 
            {
                less++; 
            }
        }

        print("LV5Q47");
        print("Vector: \n");
        utils.VectorPrint(vector);
        print($"Valor de comparação: {value}");
        print($"Maiores: {greater}");
        print($"Iguais: {equals}");
        print($"Menores: {less}");
    }
}
