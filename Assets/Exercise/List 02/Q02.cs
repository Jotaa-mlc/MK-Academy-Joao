using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q02 : MonoBehaviour
{
    [SerializeField] float number1 = 0f;
    [SerializeField] float number2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Comparação dos números: " + CompareNumber(number1, number2));
    }

    int CompareNumber(float n1,  float n2)
    {
        if (n1 > n2) return 1;
        else if (n1 == n2) return 0;
        else return -1;
    }
}
