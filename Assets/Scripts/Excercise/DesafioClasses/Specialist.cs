using UnityEngine;
using System.Threading;

public class Warrior : Character
{
    public Warrior(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    void SpecialSkill()
    {
        Debug.Log("WARRIOR HEAVY ATTACK");
    }
}
public class Mage : Character
{
    public Mage(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    public void SpecialSkill()
    {
        Debug.Log("MAGE FIRE BALL");
    }
}
public class Rogue : Character
{
    public Rogue(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    public void SpecialSkill()
    {
        Debug.Log("ROGUE SPEED BOOST");
    }
}
public class Clerig : Character
{
    public Clerig(string name, float hitPoints, float attackStrentgh, float resistence, float speed, string effectPhraseJoiningCombat, string effectPhraseDefeated) : base(name, hitPoints, attackStrentgh, resistence, speed, effectPhraseJoiningCombat, effectPhraseDefeated)
    { }
    public void SpecialSkill()
    {
        Debug.Log("CLERIG CURE");
    }
}