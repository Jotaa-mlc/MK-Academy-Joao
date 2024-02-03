using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q05 : MonoBehaviour
{
    [SerializeField] float number = 0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Raiz Cúbica: " + CubicRoot(number));
    }

    double CubicRoot(float number)
    {
        return Math.Pow(number, 1.0 / 3.0);
    }
}
