using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassChallenge : MonoBehaviour
{
    void Start()
    {
        CharacterB god = new("GOD", 100000f, 10000f, 1000f, 100000f, "Do pó vieram", "Ao pó retornarão");

        Warrior guerreiro = new("Guerreiro", 20f, 15f, 3.5f, 11f, "A guerra chegou", "Não há mais guerra");
        Mage mago = new("Mago", 12f, 14f, 1.5f, 8f, "o conhecimento está presente", "Aqui jaz a sabedoria.");
        Rogue ladino = new("Ladino", 14f, 12f, 1f, 16f, "Passei-lhe a mão :)", "Kabo a brincadeira");
        Clerig clerigo = new("Clérigo", 15f, 10f, 3f, 10f, "Receba a palavra do Senhor", "Chegou minha hora");

        Goblin goblin = new("Goblin", 15f, 10f, 3f, 10f, "HiHiHiHiHi", "BLUUUEEEEHH");
        Slime slime = new("Slime", 15f, 10f, 3f, 10f, "Squishy Squishy", "SQUIIIii...");
        OwlBear owlBear = new("Urso Coruja", 15f, 10f, 3f, 10f, "Uhhhh Uhhhh", "Roooaar");

        BossGoblin bossGoblin = new("Rei Goblin", 15f, 10f, 3f, 10f, "HAHAHAHHAHA", "NOOOOOOOO");
        BossSlime bossSlime = new("Slime Gigante", 15f, 10f, 3f, 10f, "SQUISHY", "squi squi squi...");
        BossOwlBear bossOwlBear = new("Monarca Urso Coruja", 15f, 10f, 3f, 10f, "UUUHHHHHRRROOOOAAAAR", "ploft");

        List<CharacterB> characterList = new List<CharacterB>();

        characterList.Add(guerreiro);
        characterList.Add(mago);
        characterList.Add(ladino);
        characterList.Add(clerigo);
        characterList.Add(goblin);
        characterList.Add(slime);
        characterList.Add(owlBear);
        characterList.Add(bossGoblin);
        characterList.Add(bossSlime);
        characterList.Add(bossOwlBear);

        foreach(var character in characterList)
        {
            character.EffectPhraseJoin();
            character.SimpleAttack(god);
            character.SpecialSkill();
            character.EffectPhraseLeft();
        }
    }
}
