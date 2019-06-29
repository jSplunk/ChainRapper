using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word : MonoBehaviour {

    [SerializeField] WordContainer wordContainer;

    public Type type;
    public string word;
    public bool isFilled;
    Text rapWord;

	// Use this for initialization
	void Start () {
        NewRandomWord();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewRandomWord()
    {
        WordContainer.Container container;
        container = wordContainer.GetRandomWord();

        word = container.name;
        type = container.type;

        rapWord = GetComponentInChildren<Text>();
        rapWord.text = word;
    }

    public void Click()
    {
        isFilled = true;
    }

}
