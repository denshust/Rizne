using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFactory : BaseEnemyFactory
{
    public override Dragon CreateDragon()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/Dragon");
        GameObject obj = GameObject.Instantiate(prefab);
        RedDragon dragon = obj.AddComponent<RedDragon>();
        obj.GetComponent<SpriteRenderer>().color = Color.red;

        return dragon;
    }

    public override Goblin CreateGoblin()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/Goblin");
        GameObject obj = GameObject.Instantiate(prefab);
        RedGoblin goblin = obj.AddComponent<RedGoblin>();
        obj.GetComponent<SpriteRenderer>().color = Color.red;

        return goblin;
    }


}
