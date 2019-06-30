using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCheck : MonoBehaviour {

    public timerScript timerS;
    public Sentences sentences;
    public GameObject PlayerScreen;
    public GameObject ScoreScreen;
    public GameObject BadScreen;
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


        //USE FOR CHECKING WHICH CANVAS IS ACTIVE

		//if (timerS.isGameOver && staticDataTrack.badScore)
  //      {
            
  //          Debug.Log("bad screen");
  //          BadScreen.SetActive(true);
  //          PlayerScreen.SetActive(false);
  //          if (sentences.SentencesComplete)
  //          {
  //              SceneManager.LoadScene(0);
  //          }
  //      }
  //      else if (timerS.isGameOver)
  //      {
  //          ScoreScreen.SetActive(true);
  //          PlayerScreen.SetActive(false);
  //          if (sentences.SentencesComplete)
  //          {
  //              SceneManager.LoadScene(0);
  //          }
  //      }

       
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
