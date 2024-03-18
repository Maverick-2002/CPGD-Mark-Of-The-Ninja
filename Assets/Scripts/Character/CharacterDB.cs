using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDB : ScriptableObject
{
    public Character[] character;

    public int charactercount
    {
        get
        {
            return character.Length;
        }
    }
    public Character GetCharacter(int index)
    {
        return character[index];
    }
}
