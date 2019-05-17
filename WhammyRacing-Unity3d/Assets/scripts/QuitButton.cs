using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour {
    public Button quit;
	// Use this for initialization
	void Start () {
        quit = quit.GetComponent<Button>();
        quit.onClick.AddListener(Task);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Task()
    {
        Application.Quit();
    }
}
