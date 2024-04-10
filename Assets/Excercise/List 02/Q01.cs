using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q01 : MonoBehaviour
{
    [SerializeField] int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Classifição do Número: " + ClassifyNumber(number));
    }

    int ClassifyNumber(float number)
    {
        if (number < 0)
            return -1;
        if (number > 0)
            return 1;
        else return 0;
    }
}
