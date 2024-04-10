using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class Character
{
    protected string name;
    protected float hitPoints;
    protected float attackStrentgh;
    protected float resistence;
    protected float speed;
    protected string effectPhraseJoiningCombat;
    protected string effectPhraseDefeated;

    public string GetName()
    {
        return this.name;
    }
    public void SimpleAttack(Character target) 
    {
        Debug.Log($"{this.GetName()} is attacking {target.GetName()}. Damage {this.attackStrentgh}");
        target.RecieveDamage(this.attackStrentgh);
    }

    void SpecialSkill() 
    {
        Debug.Log($"Special Skill not defined!");
    }

    public void RecieveDamage(float damage) 
    {
        Debug.Log($"{this.GetName()} recieved {damage} HP of damage.");
        if (damage > this.resistence) 
        { 
            hitPoints -= (damage - this.resistence);
        }
    }

    public void RecieveCure(float cure)
    {
        Debug.Log($"{this.GetName()} recieved {cure} HP of cure.");
        if (cure > 0)
        {
            hitPoints += cure;
        }
    }

    void EffectPhrase(string phrase) 
    {
        Debug.Log(phrase);
    }
    
    public Character(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated)
    {
        this.name = name;
        this.hitPoints = hitPoints;
        this.attackStrentgh = attackStrentgh;
        this.resistence = resistence;
        this.speed = speed;
        this.effectPhraseJoiningCombat = effectPhraseJoiningCombat;
        this.effectPhraseDefeated = effectPhraseDefeated;
    }
}
