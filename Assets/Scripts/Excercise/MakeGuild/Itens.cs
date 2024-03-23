using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    string type;
    string description;
    float value;

    Items(string _type, string _description, float _value)
    {
        this.type = _type;
        this.description = _description;
        this.value = _value;
    }
}
