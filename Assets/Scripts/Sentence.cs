using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour {


    [SerializeField] int AmountOfBlanks;
    [SerializeField] int AmountOfWords;
    //List<Blank> allBlanks;
  
    public string sentence;
    List<Word> WordsBox;

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

        int NumberOfBlanks = AmountOfBlanks;
        int BlanksFilled = 0;

        Word tmp = new Word();

        for (int i = 0; i < WordsBox.Capacity-1; i++)
        { 
            if (WordsBox[i].isFilled)
            {
                tmp = WordsBox[i];
                BlanksFilled++;
            }
        }

        if (BlanksFilled == NumberOfBlanks)
        {
            for (int i = 0; i < WordsBox.Capacity - 1; i++)
            {
                WordsBox[i].NewRandomWord();
            }

            return sentence+tmp.name;
        }

        return null;
    }

}
