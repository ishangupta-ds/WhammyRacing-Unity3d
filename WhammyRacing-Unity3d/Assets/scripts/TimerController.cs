using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
    public GameObject CountDown;
    public GameObject CarControls;
	// Use this for initialization
	void Start () {
        StartCoroutine(CountStart());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        CountDown.GetComponent<Text>().text = "2";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        CountDown.GetComponent<Text>().text = "1";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        CountDown.GetComponent<Text>().text = "Go!!";
        CarControls.SetActive(true);
        yield return new WaitForSeconds(0.57f);
        CountDown.SetActive(false);
    }
}
