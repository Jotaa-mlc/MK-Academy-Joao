using System.Collections.Generic;
using UnityEngine;
public class ClassChallenge : MonoBehaviour
{
    void Start()
    {
        CharacterB god = new("GOD", 100000f, 10000f, 1000f, 100000f, "Do p� vieram", "Ao p� retornar�o");

        List<CharacterB> characterList = new List<CharacterB>();

        characterList.Add(new Warrior("Guerreiro", 20f, 15f, 3.5f, 11f, "A guerra chegou", "N�o h� mais guerra"));
        characterList.Add(new Mage("Mago", 12f, 14f, 1.5f, 8f, "o conhecimento est� presente", "Aqui jaz a sabedoria."));
        characterList.Add(new Rogue("Ladino", 14f, 12f, 1f, 16f, "Passei-lhe a m�o :)", "Kabo a brincadeira"));
        characterList.Add(new Clerig("Cl�rigo", 15f, 10f, 3f, 10f, "Receba a palavra do Senhor", "Chegou minha hora"));

        characterList.Add(new Goblin("Goblin", 15f, 10f, 3f, 10f, "HiHiHiHiHi", "BLUUUEEEEHH"));
        characterList.Add(new Slime("Slime", 15f, 10f, 3f, 10f, "Squishy Squishy", "SQUIIIii..."));
        characterList.Add(new OwlBear("Urso Coruja", 15f, 10f, 3f, 10f, "Uhhhh Uhhhh", "Roooaar"));

        characterList.Add(new BossGoblin("Rei Goblin", 15f, 10f, 3f, 10f, "HAHAHAHHAHA", "NOOOOOOOO"));
        characterList.Add(new BossSlime("Slime Gigante", 15f, 10f, 3f, 10f, "SQUISHY", "squi squi squi..."));
        characterList.Add(new BossOwlBear("Monarca Urso Coruja", 15f, 10f, 3f, 10f, "UUUHHHHHRRROOOOAAAAR", "ploft"));

        foreach (var character in characterList)
        {
            character.EffectPhraseJoin();
            character.SimpleAttack(god);
            character.SpecialSkill();
            character.EffectPhraseLeft();
        }
    }
}