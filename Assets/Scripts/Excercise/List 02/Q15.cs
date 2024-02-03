using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Q15 : MonoBehaviour
{
    /**
     * TAMBÉM INCLUI A QUESTÃO 16
     * **/
    [SerializeField] string date = "01/01/0001";
    // Start is called before the first frame update
    void Start()
    {
        print(ConvertDate(date));
    }

    string ConvertDate(string date_str)
    {
        var date = DateTime.Parse(date_str);

        return date.ToString("dd 'de' MMMM 'de' yyyy");
    }
}
