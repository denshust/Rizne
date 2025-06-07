using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData playerData;

    private void Start()
    {
        playerData.transform = transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerData.health += 10;
            Debug.Log(playerData.health);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(playerData.quests[0].progress >= 1)
            {
                Debug.Log("DONE");
                playerData.coins += playerData.quests[0].gold;
                playerData.exp += playerData.quests[0].xp;
                playerData.quests[0].progress = 0;
            }
            else
            {
                playerData.quests[0].progress += 0.1f;
                Debug.Log(playerData.quests[0].progress);
            }

        }
    }
}
