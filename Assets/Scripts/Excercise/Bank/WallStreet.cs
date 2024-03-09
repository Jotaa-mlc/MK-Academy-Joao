using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStreet : MonoBehaviour
{

    Banco banco = new();
    // Start is called before the first frame update
    void Start()
    {
        banco.CriarContaBancaria("José Algusto", 001, 1234.56f);
    }
}
