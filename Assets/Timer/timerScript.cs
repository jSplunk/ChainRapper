using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    Slider timeLeftBar;
    public float timeMax = 10.0f;
    [SerializeField] private float timeSpeed = 10.0f;
    public float timeLeft;
    public GameObject timesUpText;
    public GameObject chainCounterText;
    public SentenceContainer sentCont;
    public List<string> words;
    public Word word1;
    public Word word2;
    public Word word3;
    public GameObject scoreText;
    public Text sentenceBox;
    public AudioSource aSource1; //reserved for the back music
    public AudioSource aSource2;
    public AudioSource aSource3;
    public AudioSource aSource4;
    public AudioClip aBeat1;
    public AudioClip aBeat2;
    public AudioClip aBeat3;
    public AudioClip aBeat4;
    public AudioClip recordScratch;
    public AudioClip crowd_cheer;
    public AudioClip crowd_boo;
    public AudioClip chains_ayo;
    public AudioClip chains_uhh;
    private bool oneFlag;
    private bool secFlag;
    private bool thirdFlag;
    private bool fourthFlag;
    private bool isClicked = false;
    public bool isGameOver = false;

    public Animator chains_Animator;
    public GameObject tempAnimator;
    public Animator[] crowd_Animator;
    public Animator light_Animator;
    public Animator speaker_Animator;

    public int counter = 0;

    //private float middleSectionSize = 0.6f;
    //private float outsideSectionSize = 1.5f;


    void Start()
    {
        //attaching animator to gameObject
        //chains_Animator = gameObject.GetComponent<Animator>();
        crowd_Animator = tempAnimator.GetComponentsInChildren<Animator>();
        //light_Animator = gameObject.GetComponent<Animator>();
        //speaker_Animator = gameObject.GetComponent<Animator>();

        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        sentenceBox.text = sentCont.sentences[counter];
        GenerateRandomWord();
        Debug.Log(sentCont.sentences.Length);

    }

    void TimerReset()
    {
        timesUpText.SetActive(false);
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        timeLeft = 0;
        if(!isClicked)
        {
            staticDataTrack.ResetChain();
        }
        isClicked = false;
    }

    void Update()
    {
        if(timeMax >= 16)
        {
            timeMax = 15;
        }
        timeLeftBar.maxValue = timeMax;
        //update the game text
        scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();
        chainCounterText.GetComponent<Text>().text = "CHAIN: " + staticDataTrack.GetChain();

        //updating object playback speed
        light_Animator.speed = timeSpeed / 10;
        speaker_Animator.speed = timeSpeed / 5;

        //playing crowd cheers when the chain is a certain length
        if (staticDataTrack.GetChain() == 5 || staticDataTrack.GetChain() == 10 || staticDataTrack.GetChain() == 15)
        {
            aSource4.clip = crowd_cheer;
            aSource4.Play();
            //crowd_Animator.SetTrigger("Cheer");
        }

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
            staticDataTrack.AddScore(-10);
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
        if (timeLeft >= 0.838f * timeMax && timeLeft <= 1f * timeMax)
        {
            if (counter % 2 != 0)
            {
                chosenIndexPrev = chosenIndex;
            }

            if (word1.isClicked)
            {
                word1.index = chosenIndex;
            }
            else if (word2.isClicked)
            {
                word2.index = chosenIndex;
            }
            else if (word3.isClicked)
            {
                word3.index = chosenIndex;
            }

            if (counter > sentCont.sentences.Length - 2)
            {
                
                Debug.Log("GameOver");
                isGameOver = true;
               
            }
            else
            {
                //update the game counter
                counter += 1;
                //if the moment button clicked is within the blank space
                //decreases max time of timer so it scrolls faster
                timeMax -= 0.5f; //change to speed
                Debug.Log("DEV KEY PRESSED");
                //adding to score
                staticDataTrack.AddScore(10 + Mathf.RoundToInt(timeSpeed));
                //adding to the chain count
                staticDataTrack.SetChain(1);

                //trigger chains to speak
                aSource2.clip = chains_uhh;
                aSource2.Play();
                chains_Animator.SetTrigger("chains_Rap_Trigger");

                //add word to script
                SaveWord(sentCont.sentences[counter] + sentCont.words[counter][chosenIndex] + '\n');
                //Check for rhymes
                CheckRhymes();
                //update sentence box text
                sentenceBox.text = sentCont.sentences[counter];
                isClicked = true;
                TimerReset();
            }
           
        }
        else
        {
            //take away from score
            staticDataTrack.AddScore(-5);

            //trigger missed sound effects
            aSource2.clip = chains_uhh;
            aSource2.Play();
            chains_Animator.SetTrigger("chains_Rap_Trigger");
            aSource3.clip = recordScratch;
            aSource3.Play();

            //slow down timer
            timeMax += 1; //change to speed
            //reset the chain
            staticDataTrack.ResetChain();
        }
    }


    //plays the background song, this code is needed so that the song can be played faster and faster
    public void PlayBeat()
    {
        if (timeLeft >= 0 && timeLeft < timeMax * 0.25 && !oneFlag)
        {
            aSource1.clip = aBeat1;
            aSource1.Play();
            

            fourthFlag = false;
            thirdFlag = false;
            secFlag = false;
            oneFlag = true;
        }
        if (timeLeft >= timeMax * 0.25 && timeLeft < timeMax * 0.5 && !secFlag)
        {
            aSource1.clip = aBeat2;
            aSource1.Play();
            

            fourthFlag = false;
            thirdFlag = false;
            oneFlag = false;
            secFlag = true;
        }
        if (timeLeft >= timeMax * 0.5 && timeLeft < timeMax * 0.75 && !thirdFlag)
        {
            aSource1.clip = aBeat3;
            aSource1.Play();
            

            fourthFlag = false;
            secFlag = false;
            oneFlag = false;
            thirdFlag = true;
        }
        if (timeLeft >= timeMax * 0.75 && timeLeft <= timeMax * 1 && !fourthFlag)
        {
            aSource1.clip = aBeat4;
            aSource1.Play();
            

            thirdFlag = false;
            secFlag = false;
            oneFlag = false;
            fourthFlag = true;
        }
    }

    List<int> temp = new List<int>
    {
        0,1,2,
    };



    public void GenerateRandomWord()
    {
        words = sentCont.words[counter];
        temp.Shuffle();
        word1.word = words[temp[0]];
        word1.index = temp[0];
        word2.word = words[temp[1]];
        word2.index = temp[1];
        word3.word = words[temp[2]];
        word3.index = temp[2];
    }


    //run after counter increased
    public void CheckRhymes()
    {
        if (counter % 2 == 0)
        {
            if (chosenIndex == chosenIndexPrev && counter > 0)
            {
                //Play sound
                //Crowd Cheer
                //staticDataTrack.AddScore(99);
                Debug.Log("thyme");
            }
        }
    }

    //saving words when button pressed
    public void SaveWord(string word)
    {
        staticDataTrack.AddToWordList(word);
    }

    //test------------
    //Take this from button pressed
    public int chosenIndex;
    public int chosenIndexPrev;

    //Assign it to buttons as the first function run
    public void SetChosenIndex(Word ww)
    {
        Debug.Log(counter);
        if (timeLeft >= 0.838f * timeMax && timeLeft <= 1f * timeMax)
        {
            if (counter % 2 != 0)
            {
                chosenIndexPrev = chosenIndex;
            }
            chosenIndex = ww.index;
        }
    }
}

