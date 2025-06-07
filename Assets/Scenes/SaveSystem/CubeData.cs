using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class CubeData
{
    public Vector3 position;
    public Quaternion rotation;

    public CubeData(Vector3 pos, Quaternion rot)
    {
        position = pos;
        rotation = rot;
    }
}