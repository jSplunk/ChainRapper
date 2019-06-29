using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour {


    //[SerializeField] int AmountOfBlanks;
    //[SerializeField] int AmountOfWords;
    //List<Blank> allBlanks;
  
    public SentenceContainer sentCont;
    public timerScript timer;
    List<Word> WordsBox;
    Word tmp;

	// Use this for initialization
	void Start () {

        WordsBox = new List<Word>();

        Word[] tmp = GetComponentsInChildren<Word>();

        for(int i = 0; i < tmp.Length; i++)
        {
            WordsBox.Add(tmp[i]);
        }            
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string isSentanceComplete()
    {

        //int NumberOfBlanks = AmountOfBlanks;
        //int BlanksFilled = 0;

        //Word tmp = WordsBox[0];

        //for (int i = 0; i < WordsBox.Capacity-1; i++)
        //{ 
        //    if (WordsBox[i].isFilled)
        //    {
        //        tmp = WordsBox[i];
        //        BlanksFilled++;
        //    }
        //}
        


        if (true)//BlanksFilled == NumberOfBlanks)
        {
            for (int i = 0; i < WordsBox.Capacity - 1; i++)
            {
               //WordsBox[i].NewRandomWord();
            }

            return sentCont.sentences[timer.counter]+tmp.word;
        }
    }

    //public void setTmp(Word wordRef)
    //{
    //    tmp = wordRef;
    //}

}
