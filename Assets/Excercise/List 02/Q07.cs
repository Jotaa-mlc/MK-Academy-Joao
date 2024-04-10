using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q07 : MonoBehaviour
{
    [SerializeField] int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Ftorial de " + number + " é: " + Factorial(number));
    }

    int Factorial( int number)
    {
        int factorial = 1;

        for (int i = number; i > 0; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}
