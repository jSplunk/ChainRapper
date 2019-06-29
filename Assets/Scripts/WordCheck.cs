﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCheck : MonoBehaviour {


    public Word chosenWord;
    public Blank chosenBlank;

    [SerializeField]Sentance currentSentance;

    public List<Word> chosenWords;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        

		if (currentSentance.isSentanceComplete())
        {
            Debug.Log("Quit");
            Application.Quit();
        }
	}

    bool DoesItFit()
    {
        if (chosenWord.type == chosenBlank.type)
        {
            return true;
        }

        return false;
    }

    public bool SaveChoice()
    {
        if (DoesItFit())
        {
            chosenWords.Add(chosenWord);
            return true;
        }

        return false;
    }



}
