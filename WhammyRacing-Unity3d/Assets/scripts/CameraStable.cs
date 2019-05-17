using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {
    public GameObject Car;
    private float carX, carY, carZ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        carY = Car.transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0, carY, 0);
    }
}
