using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{

    public static float currentTime = 0.0f;
    Text curText;

    // Use this for initialization
    void Start ()
    {
        curText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    curText.text = "Current time: " + currentTime.ToString();
	}
/*
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Fin"))
        {
            //startTime = curTime;
            currentTimeText.text = "Current Time: " + "test";
        }
    }*/
}
