using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    string name;
    int hitPoints;
    int damage;

    public Character(string _name, int _hitPoints, int _damage)
    {
        name = _name;
        hitPoints = _hitPoints;
        damage = _damage;
    }

    public void SetHitPoints(int damage) 
    {

    }
}
