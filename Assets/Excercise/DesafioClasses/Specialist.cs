using UnityEngine;
using System.Threading;

public class Warrior : CharacterB
{
    public Warrior(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("WARRIOR HEAVY ATTACK");
    }
}
public class Mage : CharacterB
{
    public Mage(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("MAGE FIRE BALL");
    }
}
public class Rogue : CharacterB
{
    public Rogue(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("ROGUE SPEED BOOST");
    }
}
public class Clerig : CharacterB
{
    public Clerig(string _name, float _hitPoints, float _attackStrentgh, float _resistence, float _speed, string _effectPhraseJoiningCombat, string _effectPhraseDefeated) : base(_name, _hitPoints, _attackStrentgh, _resistence, _speed, _effectPhraseJoiningCombat, _effectPhraseDefeated)
    { }
    public override void SpecialSkill()
    {
        Debug.Log("CLERIG CURE");
    }
}