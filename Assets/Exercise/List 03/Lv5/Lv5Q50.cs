using UnityEngine;

public class Lv5Q50 : MonoBehaviour
{
    int valorSorteado;
    int chute, chuteMin = 0, chuteMax = 100;
    int tentativas = 0;
    void Start()
    {
        print("Lv5Q50");
        valorSorteado = Random.Range(0, 100);
        bool acertou = false;

        while (!acertou)
        {
            tentativas++;
            chute = Random.Range(chuteMin, chuteMax);
            print($"Tentativa: {tentativas}; Chute: {chute};");

            acertou = (chute == valorSorteado);
            if (acertou)
            {
                print("ACERTOU!!!");
            }
            else if (chute > valorSorteado)
            {
                print("O chute é maior que o valor");
                chuteMax = chute;
            }
            else if (chute < valorSorteado)
            {
                print("O chute é menor que o valor");
                chuteMin = chute;
            }
        }
        print($"Levou um total de {tentativas} para acertar");
    }
}
