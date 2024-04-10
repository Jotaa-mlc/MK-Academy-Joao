using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class CharacterB
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
    public virtual void SimpleAttack(CharacterB target) 
    {
        Debug.Log($"{this.GetName()} is attacking {target.GetName()}. Damage {this.attackStrentgh}");
        target.RecieveDamage(this.attackStrentgh);
    }

    public virtual void SpecialSkill() 
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

    public void EffectPhraseJoin() 
    {
        Debug.Log(this.effectPhraseJoiningCombat);
    }
    public void EffectPhraseLeft()
    {
        Debug.Log(this.effectPhraseDefeated);
    }

    public CharacterB() { }
    public CharacterB(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated)
    {
        this.name = _name;
        this.hitPoints = _hitPoints;
        this.attackStrentgh = _attackStrentgh;
        this.resistence = _resistence;
        this.speed = _speed;
        this.effectPhraseJoiningCombat = _effectPhraseJoiningCombat;
        this.effectPhraseDefeated = _effectPhraseDefeated;
    }
}
