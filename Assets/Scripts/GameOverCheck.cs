using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCheck : MonoBehaviour {

    public timerScript timerS;
    public GameObject PlayerScreen;
    public GameObject ScoreScreen;
    //public Word chosenWord;
    //public Blank chosenBlank;

    //public List<string> sentences;

    //[SerializeField]Sentence currentSentance;

    //public List<Word> chosenWords;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update () {
		if (timerS.isGameOver)
        {
            ScoreScreen.SetActive(true);
            PlayerScreen.SetActive(false);
           
        }
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
