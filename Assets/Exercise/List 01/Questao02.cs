using UnityEngine;

public class Questao2 : MonoBehaviour
{

    public int anoNascimento = 0;
    public int anoAtual = System.DateTime.Now.Year;
    public const int idadeMinima = 16;
    // Start is called before the first frame update
    void Start()
    {
        if (anoAtual - anoNascimento >= idadeMinima)//Pode votar
        {
            print("Pode votar.");
        }
        else
        {
            print("Não pode votar.");
        }
    }
}
