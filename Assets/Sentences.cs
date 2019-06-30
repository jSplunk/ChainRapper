﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sentences : MonoBehaviour {

    public timerScript timerS;
    Text sentenceText;
    bool stringOutput = false;
    //List<string> sentences;

	// Use this for initialization
	void Start () {
        sentenceText = GetComponent<Text>();
        sentenceText.text = "";
        //sentences = wc.sentences;

        Debug.Log(staticDataTrack.readOut.Count);
        
	}
	
	// Update is called once per frame
	void Update () {

        if (timerS.isGameOver && !stringOutput)
        {

            if (staticDataTrack.readOut.Count == 0) sentenceText.text = "None";

            foreach (string s in staticDataTrack.readOut)
            {
                sentenceText.text += s;
            }
            stringOutput = true;
        }
    }
}
