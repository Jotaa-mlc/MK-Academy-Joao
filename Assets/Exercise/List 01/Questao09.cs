using UnityEngine;

public class Questao9 : MonoBehaviour
{
    public int[] valores = new int[3];
    // Start is called before the first frame update
    void Start()
    {
        int max = valores[0];

        foreach (int i in valores)
        {
            if (i > max)
            {
                max = i;
            }
        }

        print(max);
    }
}
