using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q17 : MonoBehaviour
{
    [SerializeField] int valor1 = 0;
    [SerializeField] int valor2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        print($"Antes da troca: {valor1}, {valor2}");
        ChangeValues(ref valor1, ref valor2);
        print($"Depois da troca: {valor1}, {valor2}");
    }

    void ChangeValues(ref int a, ref int b)
    {
        int temp = a; 
        a = b;
        b = temp;
    }
}
