using UnityEngine;

public class Lv5Q45 : MonoBehaviour
{
    [SerializeField] int sizeOfVector = 10;
    // Start is called before the first frame update
    void Start()
    {
        int[] vector = InitVector(sizeOfVector, 0, 1000);
        PrintVector(vector, true);
    }
    public int[] InitVector(int n, int min, int max)
    {
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            vector[i] = Random.Range(min, max);
        }

        return vector;
    }
    public void PrintVector(int[] vector, bool reverse)
    {
        for (int i = vector.Length - 1; i >= 0; i--)
        {
            print(vector[i]);
        }
    }
}
