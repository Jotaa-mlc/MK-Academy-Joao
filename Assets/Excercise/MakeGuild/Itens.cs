using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public string Type { get; set; }
    public string Description { get; set; }
    public float Value 
    { 
        get { return Value; }
        set
        {
            if (value >= 0)
            {
                Value = value;
            }
        }
    }

    public Items() { }
    public Items(string _type, string _description, float _value)
    {
        this.Type = _type;
        this.Description = _description;
        this.Value = _value;
    }
}
