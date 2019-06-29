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

    public int counter = 0;

    //private float middleSectionSize = 0.6f;
    //private float outsideSectionSize = 1.5f;


    void Start()
    {
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        sentenceBox.text = sentCont.sentences[counter];
        GenerateRandomWord();

    }

    void TimerReset()
    {
        timesUpText.SetActive(false);
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        if (!isClicked)
            staticDataTrack.AddScore(-10);
        timeLeft = 0;
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
            timeMax -= 1;
            Debug.Log("DEV KEY PRESSED");
            staticDataTrack.AddScore(10);
            scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();
            counter += 1;
            sentenceBox.text = sentCont.sentences[counter];
            isClicked = true;
            TimerReset();
        }
        else
        {
            staticDataTrack.AddScore(-5);
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
        words = sentCont.words[counter];
        word1.word = words[0];
        word2.word = words[1];
        word3.word = words[2];
    }

}

