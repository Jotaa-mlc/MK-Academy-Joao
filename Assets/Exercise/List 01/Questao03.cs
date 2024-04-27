using UnityEngine;

public class Questao3 : MonoBehaviour
{

    const int senha = 1234;
    public int senhaDigitada = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (senhaDigitada == senha)
        {
            print("ACESSO PERMITIDO");
        }
        else
        {
            print("ACESSO NEAGADO");
        }
    }
}
