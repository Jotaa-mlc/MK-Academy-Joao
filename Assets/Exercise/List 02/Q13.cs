using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q13 : MonoBehaviour
{
    /**
     *TAMB�M INCLUI A QUEST�O 14 
     **/
    [SerializeField] int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        List<int> dividers = new List<int>();

        dividers = GetDividers(number);

        foreach (int i in dividers)
        {
            print(i);
        }

    }

    List<int> GetDividers(int n)
    {
        List <int> dividers = new List<int>();
        dividers.Add(n);

        for (int i = n/2; i > 0; i--)
        {
            if (n % i == 0)
            {
                dividers.Add(i);
            }
        }

        return dividers;
    }
}
