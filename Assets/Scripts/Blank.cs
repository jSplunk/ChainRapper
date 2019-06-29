using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blank : MonoBehaviour {

    public Type type;
    public bool isFilled;
    public string blankWord;
    Text word;

	// Use this for initialization
	void Start () {
        blankWord = "";
        word = GetComponentInChildren<Text>();
        word.text = blankWord;
        isFilled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
