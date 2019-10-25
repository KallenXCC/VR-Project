using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameManager : MonoBehaviour {
    public int score = 0;
    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "Score = 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void incrementScore()
    {
        Debug.Log("increment");
        score++;
        text.text = "Score = " + score;
    }
}
