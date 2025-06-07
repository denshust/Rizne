using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public Player player;
    string folderPath;
    [SerializeField] string fileName = "/testPlayerData.json";

    private void Start()
    {
        folderPath = Application.persistentDataPath;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveData(player.playerData);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.playerData = LoadData<PlayerData>();
        }
    }



    public void SaveData<T>(T playerData)
    {
        Debug.Log("Saving");
        string playerDataJson = JsonUtility.ToJson(playerData); // SEREALIZATION
        Debug.Log($"JSON DATA : {playerDataJson}");

        using (var writer = new StreamWriter(folderPath+fileName))
        {
            Debug.Log($"Saved in : {folderPath + fileName}");
            writer.Write(playerDataJson);
            Debug.Log("Saved");
        }
        //PlayerPrefs.SetString("playerData", playerDataJson); // Save string
    }

    public T LoadData<T>()
    {
        Debug.Log("Loading");
        //string playerJson = PlayerPrefs.GetString("playerData"); // Load string
        string dataJson = "";

        using (var reader = new StreamReader(folderPath + fileName))
        {
            Debug.Log($"Loading from : {folderPath + fileName}");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                dataJson += line;
            }
        }

        Debug.Log($"LOADED JSON : {dataJson}");

        T data = JsonUtility.FromJson<T>(dataJson);
        Debug.Log("Loaded");
        return data;
    }
}
