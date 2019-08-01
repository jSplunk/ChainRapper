using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCheck : MonoBehaviour {


    public Word chosenWord;
    //public Blank chosenBlank;

    public List<string> sentences;

    [SerializeField]Sentence currentSentance;

    public List<Word> chosenWords;

	// Use this for initialization
	void Start () {
        sentences = new List<string>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //public void ButtonRefresh()
    //{
    //    sentences.Add(currentSentance.isSentanceComplete());
    //}

    //bool DoesItFit()
    //{
    //    if (chosenWord.type == chosenBlank.type)
    //    {
    //        return true;
    //    }

    //    return false;
    //}

    //public bool SaveChoice()
    //{
    //    if (DoesItFit())
    //    {
    //        chosenWords.Add(chosenWord);
    //        return true;
    //    }

    //    return false;
    //}



}
