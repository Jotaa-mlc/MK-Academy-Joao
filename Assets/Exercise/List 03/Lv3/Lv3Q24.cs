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
            if (Input.GetKeyDown(KeyCode.Keypad1))//é multiplo?
            {
                print("Um dos números é multiplo do outro? " + YesOrNo(AreMultiple(number1, number2)));
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))//os 2 são pares
            {
                print("Ambos números são pares? " + YesOrNo(AreEven(number1, number2)));
            }

            if (Input.GetKeyDown(KeyCode.Keypad3))//média > 7
            {
                print("A média dos números é maior que 7? " + YesOrNo(AvarageGratherThan7(number1, number2)));
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
        print("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
        print("2 – Verificar se os dois números lidos são pares");
        print("3 – Verificar se a média dos dois números é maior ou igual a 7.");
        print("4 – Sair");
    }

    string YesOrNo(bool param)
    {
        if (param)
        {
            return "sim";
        }
        else
        {
            return "não";
        }
    }
}
