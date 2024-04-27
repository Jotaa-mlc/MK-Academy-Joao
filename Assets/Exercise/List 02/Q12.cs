using UnityEngine;

public class Q12 : MonoBehaviour
{
    [SerializeField] int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("É primo? " + IsPrime(number));
    }

    bool IsPrime(int n)
    {
        bool isPrime = true;

        for (int i = n / 2; i > 1; i--)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
}
