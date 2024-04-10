using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q09 : MonoBehaviour
{
    [SerializeField] string text = "";
    char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'y', 'w', 'z' };

    // Start is called before the first frame update
    void Start()
    {
        print("Quantidade de consoantes: " + CountConsonants(text));
    }

    int CountConsonants(string txt)
    {
        int numberOfConsonants = 0;
        foreach (char character in txt)
        {
            foreach (char consonant in consonants)
            {
                if (character == consonant)
                {
                    numberOfConsonants++;
                }
            }

        }

        return numberOfConsonants;
    }
}
