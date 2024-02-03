using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questao8 : MonoBehaviour
{
    public int nLados = 0;
    public float lado = 0f;
    // Start is called before the first frame update
    void Start()
    {
        float area = 0f;
        if (nLados < 3)
        {
            print("NÃO É UM POLÍGONO!");
        }
        else if (nLados > 5)
        {
            print("POLÍGONO NÃO IDENTIFICADO!");
        }
        else
        {
            switch (nLados)
            {
                case 3:
                    print("TRIANGULO!");
                    area = AreaTriangulo(lado);
                    break;
                case 4:
                    print("QUADRADO!");
                    area = AreaQuadrado(lado);
                    break;
                case 5:
                    print("PENTAGONO!");
                    area = AreaPentagono(lado);
                    break;
            }
            print(area);
        }
    }

    //Aredondamento de RAIZ DE 3 para 1.73205
    float AreaTriangulo(float lado)
    {
        float altura = 1.73205f * lado / 2;
        float area = altura * lado / 2;
        return area;
    }

    float AreaQuadrado(float lado)
    {
        float area = lado * lado;
        return area;
    }

    float AreaPentagono(float lado)
    {
        float perimetro = 5 * lado;
        float apotema = 1.73205f * lado / 2;
        float area = perimetro * apotema / 2;
        return area;
    }
}
