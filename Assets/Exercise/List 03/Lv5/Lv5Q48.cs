using UnityEngine;

public class Lv5Q48 : MonoBehaviour
{
    Utils utils = new();
    void Start()
    {
        int[] ageCandidates = new int[20];
        string[] nameCandidates = { "Alice", "Sofia", "Beatriz", "Lara", "Valentina", "Luisa", "Laura", "Júlia", "Ágata", "Alicia", "Bianca", "Yasmin", "Manuela", "Clara", "Gabriela", "Ana", "Giovana", "Melissa", "Heloísa", "Isadora" };

        ageCandidates = utils.VectorInit(ageCandidates.Length, 16, 23);

        for (int i = 0; i < ageCandidates.Length; i++)
        {
            if (ageCandidates[i] <= 20 && ageCandidates[i] >= 18)
            {
                print($"Modelo aprovada: {nameCandidates[i]}");
            }
        }
    }
}
