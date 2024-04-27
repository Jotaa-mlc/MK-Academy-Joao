using UnityEngine;

public class Lv2Q12 : MonoBehaviour
{
    [SerializeField] int number1 = 0;
    [SerializeField] int number2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("A diferença entre os números é: " + Module(number1 - number2));
    }

    int Module(int i)
    {
        int module = i > 0 ? i : i * -1;
        return module;
    }
}
