using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighsoreScript : MonoBehaviour
{

    public Text highScore;

	// Use this for initialization
	void Start ()
	{
	    highScore = GetComponent<Text>();
	    //highScore.text = "Highscore: " + PlayerPrefs.GetFloat("score");
	}
	
	// Update is called once per frame
	void Update () {
	    highScore.text = "Highscore: " + PlayerPrefs.GetFloat("score");
    }
}
