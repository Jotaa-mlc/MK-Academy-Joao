using System.Collections.Generic;
using UnityEngine;

public class Guild : MonoBehaviour
{
    void Start()
    {
        Items espada = new("weapon", "espada longa", 10);
        Items escudo = new("shield", "Escudo de aco grande", 15);
        Items arco = new("weapon", "arco e flecha longo", 12);
        Items pexera = new("weapon", "Pexeira velha", 5);
        Items armadura = new("armour", "Armadura leve", 20);

        List<Items> itemsList = new();

        itemsList.Add(espada);
        itemsList.Add(escudo);
        itemsList.Add(arco);
        itemsList.Add(pexera);
        itemsList.Add(armadura);

        Inventory mercador = new(50f, itemsList);
        Inventory aventureiro = new(40f);

        mercador.PrintAllInfo();
        aventureiro.PrintAllInfo();

        mercador.Sell(arco, aventureiro);

        mercador.PrintAllInfo();
        aventureiro.PrintAllInfo();
    }
}
