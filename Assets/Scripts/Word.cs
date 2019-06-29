using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word : MonoBehaviour {

    public Type type;
    public string word;
    Text rapWord;

	// Use this for initialization
	void Start () {

        rapWord = GetComponentInChildren<Text>();
        rapWord.text = word;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
