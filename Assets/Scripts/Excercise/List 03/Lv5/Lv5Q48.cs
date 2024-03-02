using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv5Q48 : MonoBehaviour
{
    Lv5Q45 test;
    void Start()
    {
        test = this.gameObject.GetComponent<Lv5Q45>();

        int[] ageCandidates = new int[20];
        string[] nameCandidates = { "Alice", "Sofia", "Beatriz", "Lara", "Valentina", "Luisa", "Laura", "Júlia", "Ágata", "Alicia", "Bianca", "Yasmin", "Manuela", "Clara", "Gabriela", "Ana", "Giovana", "Melissa", "Heloísa", "Isadora"};

        ageCandidates = test.InitVector(ageCandidates.Length, 16, 23);

        for (int i = 0; i < ageCandidates.Length; i++)
        {
            if (ageCandidates[i] <= 20 && ageCandidates[i] >= 18)
            {
                print($"Modelo aprovada: {nameCandidates[i]}");
            }
        }
    }
}
