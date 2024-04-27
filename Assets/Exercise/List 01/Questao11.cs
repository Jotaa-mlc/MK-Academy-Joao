using UnityEngine;

public class Questao11 : MonoBehaviour
{
    public float[] angulos = new float[3];
    // Start is called before the first frame update
    void Start()
    {
        bool ehAcutangulo = true;
        foreach (float i in angulos)
        {
            if (i == 90)
            {
                print("RETÂNGULO!");
                ehAcutangulo = false;
            }

            if (i > 90)
            {
                print("OBTUSÂNGULO");
                ehAcutangulo = false;
            }
        }

        if (ehAcutangulo)
            print("ACUTÂNGULO!");
    }
}
