using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy : BaseStats
{
   public string enemyName;

    public enum Enemy
    {
        ORGE,
        GOBLIN,
        RATS,
        WOLVES,
        BARDS,
    }

    public Enemy EnemyType;
}
