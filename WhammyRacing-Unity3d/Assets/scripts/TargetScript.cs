using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    public GameObject mark01, mark02, mark03, mark04, mark05, mark06, mark07, mark08,mark09, mark10, mark11, target;
    public int targetPos;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(targetPos == 0)
        {
            target.transform.position = mark01.transform.position;
        }
        if (targetPos == 1)
        {
            //targetPos = 1;
            target.transform.position = mark02.transform.position;
        }
        if (targetPos == 2)
        {
            //targetPos = 1;
            target.transform.position = mark03.transform.position;
        }
        if (targetPos == 3)
        {
            //targetPos = 1;
            target.transform.position = mark04.transform.position;
        }
        if (targetPos == 4)
        {
            //targetPos = 1;
            target.transform.position = mark05.transform.position;
        }
        if (targetPos == 5)
        {
            //targetPos = 1;
            target.transform.position = mark06.transform.position;
        }
        if (targetPos == 6)
        {
            //targetPos = 1;
            target.transform.position = mark07.transform.position;
        }
        if (targetPos == 7)
        {
            //targetPos = 1;
            target.transform.position = mark08.transform.position;
        }
        if (targetPos == 8)
        {
            //targetPos = 1;
            target.transform.position = mark09.transform.position;
        }
        if (targetPos == 9)
        {
            //targetPos = 1;
            target.transform.position = mark10.transform.position;
        }
        if (targetPos == 10)
        {
            //targetPos = 1;
            target.transform.position = mark11.transform.position;
        }

    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("AICar"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            targetPos++;
            if(targetPos == 11)
            {
                targetPos = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
