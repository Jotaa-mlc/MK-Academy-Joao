using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public string Type { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public void PrintItem()
    {
        Debug.Log($"Tipo: {this.Type} | Descrição: {this.Description} | Valor: {this.Value}");
    }
    public Items() { }
    public Items(string _type, string _description, int _value)
    {
        this.Type = _type;
        this.Description = _description;
        this.Value = _value;
    }
}
