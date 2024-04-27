using UnityEngine;

public class Lv5Q46 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 5;
    [SerializeField] bool multEscalar = false;//Dúvida sobre a forma correta de calcular o produto escalar de vetores

    Utils utils = new();
    void Start()
    {
        int[] Vx = utils.VectorInit(sizeOfVector, 0, 1000);
        int[] Vy = utils.VectorInit(sizeOfVector, 0, 1000);
        float somaEscalar = 0;

        if (multEscalar)
        {
            for (int i = 0; i < sizeOfVector; i++)
            {
                somaEscalar += Vx[i] * Vy[i];
            }
        }
        else
        {
            foreach (int x in Vx)
            {
                foreach (int y in Vy)
                {
                    somaEscalar += x * y;
                }
            }
        }

        print("Lv5Q46");
        utils.VectorPrint(Vx);
        utils.VectorPrint(Vy);
        print($"Soma Escalar: {somaEscalar}");
    }
}
