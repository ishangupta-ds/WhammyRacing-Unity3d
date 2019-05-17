using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControl : MonoBehaviour {
    public GameObject Car1, Car2;
	// Use this for initialization
	void Start () {
        Car1.GetComponent<Rigidbody>().isKinematic = false;
        Car2.GetComponent<Rigidbody>().isKinematic = false;
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
