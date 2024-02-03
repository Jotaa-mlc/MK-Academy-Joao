using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q04 : MonoBehaviour
{
    [SerializeField] int baseOfPower = 0;
    [SerializeField] int exponent = 1;
    // Start is called before the first frame update
    void Start()
    {
        print("Potência: " + Power(baseOfPower, exponent));
    }

    double Power(float baseOfPower, int exponent)
    {
        return Math.Pow(baseOfPower, exponent);
    }
}
