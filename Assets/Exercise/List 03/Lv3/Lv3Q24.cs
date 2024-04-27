using UnityEngine;

public class Lv3Q24 : MonoBehaviour
{
    [SerializeField] int number1 = 0;
    [SerializeField] int number2 = 1;
    bool exit = false;
    bool menuPrinted = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!menuPrinted)
        {
            PrintMenu();
            menuPrinted = true;
        }

        if (!exit && Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))//� multiplo?
            {
                print("Um dos n�meros � multiplo do outro? " + YesOrNo(AreMultiple(number1, number2)));
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))//os 2 s�o pares
            {
                print("Ambos n�meros s�o pares? " + YesOrNo(AreEven(number1, number2)));
            }

            if (Input.GetKeyDown(KeyCode.Keypad3))//m�dia > 7
            {
                print("A m�dia dos n�meros � maior que 7? " + YesOrNo(AvarageGratherThan7(number1, number2)));
            }

            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                exit = true;
            }

            menuPrinted = false;
        }
    }

    #region Comparing functions
    bool AreMultiple(int a, int b)
    {
        bool areMultiple = false;

        if (a % b == 0 || b % a == 0)
        {
            areMultiple = true;
        }

        return areMultiple;
    }

    bool AreEven(int a, int b)
    {
        bool areEven = false;

        if (a % 2 == 0 && b % 2 == 0)
        {
            areEven = true;
        }

        return areEven;
    }

    bool AvarageGratherThan7(int a, int b)
    {
        bool gratherThan = false;

        if ((a + b) / 2 > 7)
        {
            gratherThan = true;
        }

        return gratherThan;
    }
    #endregion

    void PrintMenu()
    {
        print("1 � Verificar se um dos n�meros lidos � ou n�o m�ltiplo do outro");
        print("2 � Verificar se os dois n�meros lidos s�o pares");
        print("3 � Verificar se a m�dia dos dois n�meros � maior ou igual a 7.");
        print("4 � Sair");
    }

    string YesOrNo(bool param)
    {
        if (param)
        {
            return "sim";
        }
        else
        {
            return "n�o";
        }
    }
}
