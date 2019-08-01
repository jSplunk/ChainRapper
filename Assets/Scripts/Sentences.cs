using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sentences : MonoBehaviour {

    public timerScript timerS;
    Text sentenceText;
    bool stringOutput = false;
    public bool SentencesComplete = false;
<<<<<<< HEAD
    float speedText = 2.0f;
=======
    float speedText = 50.0f;
>>>>>>> 6eaeef96de9b0cfc0e8523c23fe88dee4daf1f72
    //List<string> sentences;

	// Use this for initialization
	void Start () {
        sentenceText = GetComponent<Text>();
        sentenceText.text = "";
        //sentences = wc.sentences;

        Debug.Log(staticDataTrack.readOut.Count);
        
	}
	
	// Update is called once per frame
	void Update () {

<<<<<<< HEAD
        //if (timerS.isGameOver && !stringOutput)
=======
        if (timerS.isGameOver && !stringOutput)
>>>>>>> 6eaeef96de9b0cfc0e8523c23fe88dee4daf1f72
        {

            if (staticDataTrack.readOut.Count == 0) sentenceText.text = "None";

            foreach (string s in staticDataTrack.readOut)
            {
                sentenceText.text += s;
            }
            stringOutput = true;
        }

<<<<<<< HEAD
        //if (timerS.isGameOver)
        {
            
            sentenceText.transform.position = new Vector2(sentenceText.transform.position.x, sentenceText.transform.position.y+speedText);
=======
        if (timerS.isGameOver)
        {
            
            sentenceText.transform.position = new Vector2(sentenceText.transform.position.x, sentenceText.transform.position.y+speedText * Time.deltaTime);
>>>>>>> 6eaeef96de9b0cfc0e8523c23fe88dee4daf1f72

            if (sentenceText.transform.position.y - sentenceText.rectTransform.rect.height/2 > Screen.height)
            {
                SentencesComplete = true;
            }
        }


    }
}
