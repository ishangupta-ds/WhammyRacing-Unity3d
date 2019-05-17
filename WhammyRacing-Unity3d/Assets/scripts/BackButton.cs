using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events;

public class BackButton : MonoBehaviour {
    public Button btn; 
	// Use this for initialization
	void Start () {
        btn = btn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}

    private void TaskOnClick()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
