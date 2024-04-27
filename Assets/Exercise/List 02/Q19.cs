using Unity.Mathematics;
using UnityEngine;

public class Q19 : MonoBehaviour
{
    /**
     * INCLUI A QUESTÃO 20
     * **/
    [SerializeField] float radius = 0f;
    // Start is called before the first frame update
    void Start()
    {
        print($"Circinferencia: {CircleCircunference(radius)}");
        print($"Area: {CircleArea(radius)}");
    }

    float CircleCircunference(float radius)
    {
        return math.PI * (radius * 2);
    }

    float CircleArea(float radius)
    {
        return math.PI * radius * radius;
    }
}
