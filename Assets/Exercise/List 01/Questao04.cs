using UnityEngine;

public class Questao4 : MonoBehaviour
{

    float valorBruto = 0.30f;
    float valorPromocao = 0.25f;
    float preco;
    int qtePromocao = 12;

    public int quantidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        preco = quantidade < qtePromocao ? valorBruto : valorPromocao;

        print("Valor total da compra: R$ " + preco * quantidade);
    }
}
