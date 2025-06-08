using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayHello : MonoBehaviour
{
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        number++;
        Debug.Log("UPDATE"+number);
    }
}
