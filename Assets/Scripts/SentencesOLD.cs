using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sentencesold : MonoBehaviour {

    public WordCheck wc;
    Text sentenceText;
    List<string> sentences;

	// Use this for initialization
	void Start () {
        sentenceText = GetComponent<Text>();
        sentences = wc.sentences;

        sentenceText.text += sentences; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
