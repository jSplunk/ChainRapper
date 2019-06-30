using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Word : MonoBehaviour {

    //[SerializeField] SentenceContainer wordList;

    //public WordContainer.Type type;
    public string word;
    public int index;
    public bool isClicked = false;
    //public timerScript timerScriptReference;
    
    //public timerScript timer;
    Text rapWord;

    private void Update()
    {
        rapWord = GetComponentInChildren<Text>();
        rapWord.text = word;
    }

    public void click()
    {
        isClicked = true;
    }


    //// Use this for initialization
    //void Start () {
    //       NewRandomWord();
    //   }

    //// Update is called once per frame
    //void Update () {

    //}

    //   public void NewRandomWord()
    //   {
    //       //WordContainer.Container container;
    //       //container = wordContainer.GetRandomWord((WordContainer.Type)timer.counter);
    //       word = wordList.words[timer.counter][Random.Range(0,wordList.words.Count)];
    //       //type = wordContainer.type;

    //       rapWord = GetComponentInChildren<Text>();
    //       rapWord.text = word;
    //   }



}
