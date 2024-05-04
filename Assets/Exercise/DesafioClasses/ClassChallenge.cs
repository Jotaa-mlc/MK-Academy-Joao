using System.Collections.Generic;
using UnityEngine;
public class ClassChallenge : MonoBehaviour
{
    void Start()
    {
        CharacterB god = new("GOD", 100000f, 10000f, 1000f, 100000f, "Do p� vieram", "Ao p� retornar�o");

        List<CharacterB> characterList = new()
        {
            new Warrior("Guerreiro", 20f, 15f, 3.5f, 11f, "A guerra chegou", "N�o h� mais guerra"),
            new Mage("Mago", 12f, 14f, 1.5f, 8f, "o conhecimento est� presente", "Aqui jaz a sabedoria."),
            new Rogue("Ladino", 14f, 12f, 1f, 16f, "Passei-lhe a m�o :)", "Kabo a brincadeira"),
            new Clerig("Cl�rigo", 15f, 10f, 3f, 10f, "Receba a palavra do Senhor", "Chegou minha hora"),
            new Goblin("Goblin", 15f, 10f, 3f, 10f, "HiHiHiHiHi", "BLUUUEEEEHH"),
            new Slime("Slime", 15f, 10f, 3f, 10f, "Squishy Squishy", "SQUIIIii..."),
            new OwlBear("Urso Coruja", 15f, 10f, 3f, 10f, "Uhhhh Uhhhh", "Roooaar"),
            new BossGoblin("Rei Goblin", 15f, 10f, 3f, 10f, "HAHAHAHHAHA", "NOOOOOOOO"),
            new BossSlime("Slime Gigante", 15f, 10f, 3f, 10f, "SQUISHY", "squi squi squi..."),
            new BossOwlBear("Monarca Urso Coruja", 15f, 10f, 3f, 10f, "UUUHHHHHRRROOOOAAAAR", "ploft")
        };

        foreach (var character in characterList)
        {
            character.EffectPhraseJoin();
            character.SimpleAttack(god);
            character.SpecialSkill();
            character.EffectPhraseLeft();
        }
    }
}