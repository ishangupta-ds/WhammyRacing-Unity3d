using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandTerrain : MonoBehaviour {
    public GameObject terrain1, terrain2;
	// Use this for initialization
	void Start () {
        int index = (int)Random.Range(0, 2);
        if(index == 0)
        {
            terrain1.SetActive(true);
        }
        else
        {
            terrain2.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
