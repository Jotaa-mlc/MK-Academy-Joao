using UnityEngine;

public class Questao1 : MonoBehaviour
{

    public int valor1 = 0;
    public int valor2 = 0;
    public int maior;
    // Start is called before the first frame update
    void Start()
    {
        maior = valor1 > valor2 ? valor1 : valor2;

        print("O numero " + maior + " é o maior dentre eles.");
    }
}
