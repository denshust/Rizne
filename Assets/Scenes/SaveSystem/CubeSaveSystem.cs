using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class CubeSaveSystem : MonoBehaviour
{
    private string folderPath;
    [SerializeField] private string fileName = "/cubeData.json";

    private void Start()
    {
        folderPath = Application.persistentDataPath;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveCubes();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadCubes();
        }
    }

    void SaveCubes()
    {
        Debug.Log("Saving cubes...");

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        SceneData data = new SceneData();

        foreach (GameObject cube in cubes)
        {
            CubeData cubeData = new CubeData(cube.transform.position, cube.transform.rotation);
            data.cubes.Add(cubeData);
        }

        string json = JsonUtility.ToJson(data, true); // Pretty print
        File.WriteAllText(folderPath + fileName, json);

        Debug.Log($"Saved {data.cubes.Count} cubes to {folderPath + fileName}");
    }

    void LoadCubes()
    {
        Debug.Log("Loading cubes...");

        string fullPath = folderPath + fileName;
        if (!File.Exists(fullPath))
        {
            Debug.LogWarning("No save file found!");
            return;
        }

        string json = File.ReadAllText(fullPath);
        SceneData data = JsonUtility.FromJson<SceneData>(json);

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        if (data.cubes.Count != cubes.Length)
        {
            Debug.LogWarning("Saved cubes count doesn't match current scene cubes count.");
        }

        for (int i = 0; i < Mathf.Min(cubes.Length, data.cubes.Count); i++)
        {
            cubes[i].transform.position = data.cubes[i].position;
            cubes[i].transform.rotation = data.cubes[i].rotation;
        }

        Debug.Log($"Loaded {data.cubes.Count} cubes from {fullPath}");
    }
}
