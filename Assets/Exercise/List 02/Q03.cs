using UnityEngine;

public class Q03 : MonoBehaviour
{
    [SerializeField] int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Par ou Impar: " + IsEven(number));
    }

    int IsEven(int number)
    {
        if (number % 2 == 0)
            return 1;
        else return -1;
    }
}
