using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    Slider timeLeftBar;
    private float timeMax = 10.0f;
    [SerializeField] private float timeSpeed = 10.0f;
    float timeLeft;
    public GameObject timesUpText;
    public SentenceContainer sentCont;
    public List<string> words;
    public Word word1;
    public Word word2;
    public Word word3;
    public GameObject scoreText;
    public Text sentenceBox;
    public AudioSource aSource;
    public AudioClip aBeat1;
    public AudioClip aBeat2;
    public AudioClip aBeat3;
    public AudioClip aBeat4;
    private bool oneFlag;
    private bool secFlag;
    private bool thirdFlag;
    private bool fourthFlag;
    private bool isClicked = false;
    public bool isGameOver = false;
    private int minScore = 0;

    public int counter = 0;

    //private float middleSectionSize = 0.6f;
    //private float outsideSectionSize = 1.5f;


    void Start()
    {
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        sentenceBox.text = sentCont.sentences[counter] + "_____";
        GenerateRandomWord();
    }

    void TimerReset()
    {
        timesUpText.SetActive(false);
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");

        //If we don't click any button, we deduct points
        if (!isClicked)
            staticDataTrack.AddScore(-10);

        timeLeft = 0;

        //Resetting the flag
        isClicked = false;
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();

        if (timeLeft < timeMax)
        {
            timesUpText.SetActive(false);
            timeLeft = timeLeft + Time.deltaTime * timeSpeed;
            timeLeftBar.value = timeLeft;
            PlayBeat();
        }
        else
        {
            timesUpText.SetActive(true);
            TimerReset();
        }

        //---------------------------------------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            checkPhase();
        }
    }

    public void checkPhase()
    {
        if (timeLeft >= sentCont.rangeMin[counter] * timeMax && timeLeft <= sentCont.rangeMax[counter] * timeMax)
        {

            //Adding each sentence to a List of strings for the game over screen
            if (word1.isClicked)
            {
                staticDataTrack.readOut.Add(sentCont.sentences[counter] + word1.word + '\n');
                word1.isClicked = false;
            }
            else if (word2.isClicked)
            {
                staticDataTrack.readOut.Add(sentCont.sentences[counter] + word2.word + '\n');
                word2.isClicked = false;
            }
            else if (word3.isClicked)
            {
                staticDataTrack.readOut.Add(sentCont.sentences[counter] + word3.word + '\n');
                word3.isClicked = false;
            }

            //Make the time max not go negative (Optional)
            if (timeMax > 2) timeMax -= 1;
            
            if (counter > sentCont.rangeMin.Length-1 || counter > sentCont.rangeMax.Length-1 || counter > sentCont.words.Count-2)
            {
                //Checking if we go to a bad score screen or a good score screen as a game over screen
                if (staticDataTrack.GetScore() < minScore)
                {
                    staticDataTrack.isBadScore(true);
                }
                isGameOver = true;
                //GAME
                //
                //OVER
            }
            else
            {
                Debug.Log("DEV KEY PRESSED");
                staticDataTrack.AddScore(10);
                scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();
                counter += 1;
                sentenceBox.text = sentCont.sentences[counter] + "_____";
                isClicked = true;
                TimerReset();
            }
            
        }
        //If we miss the timings
        else if (!(timeLeft >= sentCont.rangeMin[counter] * timeMax && timeLeft <= sentCont.rangeMax[counter] * timeMax) && (!isGameOver || !staticDataTrack.badScore) )
        {
            staticDataTrack.AddScore(-5);

            //Reset the button state
            word1.isClicked = false;
            word2.isClicked = false;
            word3.isClicked = false;
        }

        
    }

    public void PlayBeat()
    {
        if (timeLeft >= 0 && timeLeft < timeMax * 0.25 && !oneFlag)
        {
            aSource.clip = aBeat1;
            aSource.Play();
            fourthFlag = false;
            thirdFlag = false;
            secFlag = false;
            oneFlag = true;
        }
        if (timeLeft >= timeMax * 0.25 && timeLeft < timeMax * 0.5 && !secFlag)
        {
            aSource.clip = aBeat2;
            aSource.Play();
            fourthFlag = false;
            thirdFlag = false;
            oneFlag = false;
            secFlag = true;
        }
        if (timeLeft >= timeMax * 0.5 && timeLeft < timeMax * 0.75 && !thirdFlag)
        {
            aSource.clip = aBeat3;
            aSource.Play();
            fourthFlag = false;
            secFlag = false;
            oneFlag = false;
            thirdFlag = true;
        }
        if (timeLeft >= timeMax * 0.75 && timeLeft <= timeMax * 1 && !fourthFlag)
        {
            aSource.clip = aBeat4;
            aSource.Play();
            thirdFlag = false;
            secFlag = false;
            oneFlag = false;
            fourthFlag = true;
        }
    }

    public void GenerateRandomWord()
    {
        if (counter < sentCont.words.Count)
        {
            words = sentCont.words[counter];
            word1.word = words[0];
            word2.word = words[1];
            word3.word = words[2];
        }
    }

}

