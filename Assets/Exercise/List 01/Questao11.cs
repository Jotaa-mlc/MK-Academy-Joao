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
                print("RET�NGULO!");
                ehAcutangulo = false;
            }

            if (i > 90)
            {
                print("OBTUS�NGULO");
                ehAcutangulo = false;
            }
        }

        if (ehAcutangulo)
            print("ACUT�NGULO!");
    }
}
