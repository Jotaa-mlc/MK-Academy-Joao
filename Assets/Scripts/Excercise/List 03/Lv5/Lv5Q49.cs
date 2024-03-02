using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv5Q49 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 5;
    Lv5Q45 test;
    void Start()
    {
        test = this.gameObject.GetComponent<Lv5Q45>();

        int[] vector1 = test.InitVector(sizeOfVector, 0, 50);
        int[] vector2 = test.InitVector(sizeOfVector, 0, 50);
        int equals = 0;

        for(int i = 0; i < sizeOfVector; i++)
        {
            if (vector1[i] == vector2[i])
            {
                equals++;
            }
        }

        print("Lv5Q49");
        test.PrintVector(vector1, false);
        test.PrintVector(vector2, false);
        print($"Iguais: {equals}");
    }
}
