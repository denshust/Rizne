using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldFactory : BaseEnemyFactory
{
    public override Dragon CreateDragon()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/Dragon");
        GameObject obj = GameObject.Instantiate(prefab);
        GoldDragon dragon = obj.AddComponent<GoldDragon>();
        obj.GetComponent<SpriteRenderer>().color = Color.yellow;

        return dragon;
    }

    public override Goblin CreateGoblin()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/Goblin");
        GameObject obj = GameObject.Instantiate(prefab);
        GoldGoblin goblin = obj.AddComponent<GoldGoblin>();
        obj.GetComponent<SpriteRenderer>().color = Color.yellow;

        return goblin;
    }


}
