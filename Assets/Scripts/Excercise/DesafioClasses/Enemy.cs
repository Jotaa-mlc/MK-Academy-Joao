using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

#region Normal Enemies
public class Goblin : Character
{
    public Goblin(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    void SpecialSkill() 
    {
        Debug.Log("GOBLIN SNEAKY ATTACK");
    }
}
public class Slime : Character
{
    public Slime(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    void SpecialSkill()
    {
        Debug.Log("SLIME GOO ATTACK");
    }
}
public class OwlBear : Character
{
    public OwlBear(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    void SpecialSkill()
    {
        Debug.Log("ONLBEAR BITE ATTACK");
    }
}
#endregion
#region Boss Enemies
public class BossGoblin : Goblin
{
    public BossGoblin(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    new void SimpleAttack(Character target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    void SpecialSkill()
    {
        Debug.Log("BOSS GOBLIN SNEAKY ATTACK");
    }
}
public class BossSlime : Slime
{
    public BossSlime(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    new void SimpleAttack(Character target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    void SpecialSkill()
    {
        Debug.Log("BOSS SLIME GOO ATTACK");
    }
}
public class BossOwlBear : OwlBear
{
    public BossOwlBear(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    new void SimpleAttack(Character target)
    {
        float amplifier = 2.0f;
        target.RecieveDamage(this.attackStrentgh * amplifier);
    }
    void SpecialSkill()
    {
        Debug.Log("BOSS ONLBEAR BITE ATTACK");
    }
}
#endregion