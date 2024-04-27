using UnityEngine;

public class Questao6 : MonoBehaviour
{
    public int sexo = 0;
    public float altura = 0f;
    // Start is called before the first frame update
    void Start()
    {
        float pesoIdeal = 0f;
        if (sexo == 1)
        {
            pesoIdeal = PesoIdealMulher(altura);
        }
        else if (sexo == 2)
        {
            pesoIdeal = PesoIdealHomem(altura);
        }

        print(pesoIdeal);
    }

    float PesoIdealHomem(float altura)
    {
        return (72.7f * altura) - 58f;
    }

    float PesoIdealMulher(float altura)
    {
        return (62.1f * altura) - 44.7f;
    }
}
