using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv5Q46 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 5;
    [SerializeField] bool multEscalar = false;
    Lv5Q45 test;
    void Start()
    {
        test = this.gameObject.GetComponent<Lv5Q45>();

        int[] Vx = test.InitVector(sizeOfVector, 0, 1000);
        int[] Vy = test.InitVector(sizeOfVector, 0, 1000);
        float somaEscalar = 0;

        if (multEscalar)
        {
            for(int i = 0; i < sizeOfVector; i++)
            {
                somaEscalar += Vx[i] * Vy[i];
            }
        }
        else
        {
            foreach (int x in Vx)
            {
                foreach (int y in Vy)
                {
                    somaEscalar += x * y;
                }
            }
        }

        print("Lv5Q46");
        test.PrintVector(Vx, false);
        test.PrintVector(Vy, false);
        print($"Soma Escalar: {somaEscalar}");
    }
}
