using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

#region Normal Enemies
public class Goblin : CharacterB
{
    public Goblin(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill() 
    {
        Debug.Log("GOBLIN SNEAKY ATTACK");
    }
}
public class Slime : CharacterB
{
    public Slime(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("SLIME GOO ATTACK");
    }
}
public class OwlBear : CharacterB
{
    public OwlBear(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("ONLBEAR BITE ATTACK");
    }
}
#endregion
#region Boss Enemies
public class BossGoblin : Goblin
{
    public BossGoblin(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SimpleAttack(CharacterB target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    public override void SpecialSkill()
    {
        Debug.Log("BOSS GOBLIN SNEAKY ATTACK");
    }
}
public class BossSlime : Slime
{
    public BossSlime(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SimpleAttack(CharacterB target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    public override void SpecialSkill()
    {
        Debug.Log("BOSS SLIME GOO ATTACK");
    }
}
public class BossOwlBear : OwlBear
{
    public BossOwlBear(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SimpleAttack(CharacterB target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    public override void SpecialSkill()
    {
        Debug.Log("BOSS ONLBEAR BITE ATTACK");
    }
}
#endregion