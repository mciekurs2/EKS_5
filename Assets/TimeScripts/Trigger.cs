using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private bool isTiming = false;

    // Use this for initialization
    void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (isTiming == false)
	    {
	        TimeText.currentTime = Time.time;
	    }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player"){
            if ((PlayerPrefs.GetFloat("score") > TimeText.currentTime))
            {
                PlayerPrefs.SetFloat("score", TimeText.currentTime);
            }
            
            isTiming = true;
        }
    }


}
