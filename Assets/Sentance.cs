using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentance : MonoBehaviour {


    [SerializeField] int AmountOfBlanks;
    //List<Blank> allBlanks;
    List<Word> allWords;

	// Use this for initialization
	void Start () {

        allWords = new List<Word>();

        Word[] tmp = GetComponentsInChildren<Word>();

        for(int i = 0; i < tmp.Length; i++)
        {
            allWords.Add(tmp[i]);
        }

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool isSentanceComplete()
    {

        int NumberOfBlanks = AmountOfBlanks;
        int BlanksFilled = 0;


        for (int i = 0; i < allWords.Capacity-1; i++)
        { 
            if (allWords[i].isFilled)
            {
                BlanksFilled++;
            }
        }

        if (BlanksFilled == NumberOfBlanks)
        {
            for (int i = 0; i < allWords.Capacity - 1; i++)
            {
                allWords[i].NewRandomWord();
            }

            return true;
        }

        return false;
    }

}
