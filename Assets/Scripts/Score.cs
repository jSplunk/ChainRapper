using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text scoreText;

	// Use this for initialization
	void Start () {

        scoreText = GetComponent<Text>();

        scoreText.text = "Final Score: " + staticDataTrack.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
