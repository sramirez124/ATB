using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateMachine : BaseHero
{

    // Start is called before the first frame update
    void Start()
    {
        if(HeroClass == Hero.Hunter)
        {
            Strength = 52;
            Tenacity = 66;
            Intelligence = 46;
            Awareness = 78;
            Talent = 64;
            Speed = 78;
            Luck = 50;
            Armor = 1;
            Resistence = 0;
            Evasion = 17;
        }

        if(HeroClass == Hero.Librarian)
        {
            Strength = 42;
            Tenacity = 60;
            Intelligence = 78;
            Awareness = 66;
            Talent = 70;
            Speed = 70;
            Luck = 50;
            Armor = 0;
            Resistence = 1;
            Evasion = 13;

        }

        if(HeroClass == Hero.Guard)
        {
            Strength = 76;
            Tenacity = 80;
            Intelligence = 40;
            Awareness = 52;
            Talent = 72;
            Speed = 56;
            Luck = 50;
            Armor = 1;
            Resistence = 0;
            Evasion = 17;
        }

        if(HeroClass == Hero.Bard)
        {
            Strength = 44;
            Tenacity = 50;
            Intelligence = 70;
            Awareness = 68;
            Talent = 78;
            Speed = 66;
            Luck = 50;
            Armor = 0;
            Resistence = 1;
            Evasion = 11;
        }
    }

}
