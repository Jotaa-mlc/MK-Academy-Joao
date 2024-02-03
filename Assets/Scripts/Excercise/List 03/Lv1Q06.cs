using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1Q06 : MonoBehaviour
{
    [SerializeField] float temperatureCelcius = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Temperatura em °F: " +  ConvertCelciusFarenheit(temperatureCelcius));
    }

    float ConvertCelciusFarenheit(float celcius)
    {
        return (9 * celcius + 160) / 5;
    }
}
