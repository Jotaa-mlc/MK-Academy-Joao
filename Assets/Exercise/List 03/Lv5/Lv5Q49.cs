using UnityEngine;

public class Lv5Q49 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 5;

    Utils utils = new();
    void Start()
    {
        int[] vector1 = utils.VectorInit(sizeOfVector, 0, 50);
        int[] vector2 = utils.VectorInit(sizeOfVector, 0, 50);
        int equals = 0;

        for (int i = 0; i < sizeOfVector; i++)
        {
            if (vector1[i] == vector2[i])
            {
                equals++;
            }
        }

        print("Lv5Q49");
        utils.VectorPrint(vector1);
        utils.VectorPrint(vector2);
        print($"Iguais: {equals}");
    }
}
