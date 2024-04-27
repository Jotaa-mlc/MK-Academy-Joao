using UnityEngine;

public class Q11 : MonoBehaviour
{
    [SerializeField] string text = "";

    // Start is called before the first frame update
    void Start()
    {
        print("Espaços no texto: " + CountSpaces(text));
    }

    int CountSpaces(string txt)
    {
        int numberOfSpaces = 0;

        foreach (var character in txt)
        {
            if (character == ' ')
            {
                numberOfSpaces++;
            }
        }

        return numberOfSpaces;
    }
}
