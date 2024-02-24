using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lv5Q47 : MonoBehaviour
{

    Lv5Q45 test;
    [SerializeField] int sizeOfVector = 10;
    // Start is called before the first frame update
    void Start()
    {
        test = this.gameObject.GetComponent<Lv5Q45>();

        int[] vector = test.InitVector(sizeOfVector, 1, 999999);

        int value = UnityEngine.Random.Range(1, 999999);

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

        print($"Maiores: {greater}\nIguais: {equals}\nMenores: {less}");
    }
}
