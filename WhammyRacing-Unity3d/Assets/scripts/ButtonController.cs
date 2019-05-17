using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
    public Button btn;
	// Use this for initialization
	void Start () {
        btn = btn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnClick()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene((int)Random.Range(1, 7));
    }
}
