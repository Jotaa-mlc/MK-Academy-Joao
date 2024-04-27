using UnityEngine;

public class Questao5 : MonoBehaviour
{
    public int[] valores = new int[3] { 0, 0, 0 };
    // Start is called before the first frame update
    void Start()
    {
        bool ordenado = false;

        do
        {
            ordenado = true;
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i - 1] > valores[i])
                {
                    int aux = valores[i - 1];
                    valores[i - 1] = valores[i];
                    valores[i] = aux;
                    ordenado = false;
                }
            }
        } while (!ordenado);

        foreach (int i in valores)
        {
            print(i);
        }


    }
}
