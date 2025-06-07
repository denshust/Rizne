using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData 
{
    public Transform transform;
    public int health;
    public string playerName;
    public int coins;
    public int exp;

    public string[] tituls;

    public List<Quest> quests;
}
