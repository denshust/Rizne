using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyFactory 
{
    public abstract Dragon CreateDragon();
    public abstract Goblin CreateGoblin();
}
