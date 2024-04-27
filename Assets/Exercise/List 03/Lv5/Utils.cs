using UnityEngine;

public class Utils
{
    #region Vector Utilities
    public int[] VectorInit(int n, int min, int max)
    {
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            vector[i] = Random.Range(min, max);
        }

        return vector;
    }
    public void VectorPrint(int[] vector, bool reverse = false)
    {
        if (reverse)
        {
            foreach (int i in vector)
            {
                Debug.Log(i);
            }
        }
        else
        {
            for (int i = vector.Length - 1; i >= 0; i--)
            {
                Debug.Log(vector[i]);
            }
        }
    }
    #endregion
}
