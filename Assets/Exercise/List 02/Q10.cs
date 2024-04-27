using UnityEngine;

public class Q10 : MonoBehaviour
{
    [SerializeField] float temperatureCelcius = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        float temperatureKelvin = temperatureCelcius + 273.15f;
        print("Temperatura em Kelvin: " + temperatureKelvin);
    }
}
