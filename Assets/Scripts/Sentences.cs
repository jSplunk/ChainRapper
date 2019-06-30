using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sentences : MonoBehaviour {

    public timerScript timerS;
    Text sentenceText;
    bool stringOutput = false;
    public bool SentencesComplete = false;
    float speedText = 0.01f;
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

        if (timerS.isGameOver && !stringOutput)
        {

            if (staticDataTrack.readOut.Count == 0) sentenceText.text = "None";

            foreach (string s in staticDataTrack.readOut)
            {
                sentenceText.text += s;
            }
            stringOutput = true;
        }

        if (timerS.isGameOver)
        {
            
            sentenceText.transform.position = new Vector2(sentenceText.transform.position.x, sentenceText.transform.position.y+speedText);

            if (sentenceText.transform.position.y - sentenceText.rectTransform.rect.height/2 > Screen.height)
            {
                SentencesComplete = true;
            }
        }


    }
}
