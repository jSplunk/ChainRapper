using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCheck : MonoBehaviour {

    public Word chosenWord;
    public Blank chosenBlank;

    public List<Word> chosenWords;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool DoesItFit()
    {
        if (chosenWord.name == blank.type)
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
