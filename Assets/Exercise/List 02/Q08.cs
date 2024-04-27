using UnityEngine;

public class Q08 : MonoBehaviour
{
    [SerializeField] string text = "";
    char[] vowes = new char[5] { 'a', 'e', 'i', 'o', 'u' };


    // Start is called before the first frame update
    void Start()
    {
        print("Quantidade de vogais: " + CountVowels(text));
    }

    int CountVowels(string txt)
    {
        int numberOfVowels = 0;
        foreach (char character in txt)
        {
            foreach (char vowel in vowes)
            {
                if (character == vowel)
                {
                    numberOfVowels++;
                }
            }

        }

        return numberOfVowels;
    }
}
