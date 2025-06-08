using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayHello : MonoBehaviour
{
    string sayMyName = "Maksim";
	string sayYourName = "Your Name";
	// Start is called before the first frame update
	void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        Heloooooooo();
    }
    void Heloooooooo()
    {
        Debug.Log(sayMyName);
		Debug.Log(sayYourName);
	}
}
