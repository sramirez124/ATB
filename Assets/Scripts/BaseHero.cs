using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero : BaseStats
{
    public string heroName;

    public enum Hero
    {
        Hunter,
        Librarian,
        Guard,
        Bard,
    }

    public Hero HeroClass;

    public float baseHP;
    public float currentHP;

    

}
