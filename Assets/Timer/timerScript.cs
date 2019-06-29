using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    Slider timeLeftBar;
    private float timeMax = 10.0f;
    [SerializeField ] private float timeSpeed = 10.0f;
    float timeLeft;
    public GameObject timesUpText;
    public GameObject scoreText;

    //private float middleSectionSize = 0.6f;
    //private float outsideSectionSize = 1.5f;
    

    void Start()
    {
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
    }

    void TimerReset()
    {
        timesUpText.SetActive(false);
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
        staticDataTrack.AddScore(-10);
        timeLeft = 0;
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();

        if (timeLeft < timeMax)
        {
            timesUpText.SetActive(false);
            timeLeft = timeLeft + Time.deltaTime * timeSpeed;
            Debug.Log(timeLeft);
            timeLeftBar.value = timeLeft;
            Debug.Log("Time Increase");
        }
        else
        {
            timesUpText.SetActive(true);
            TimerReset();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            checkPhase();
        }
    }

    public void checkPhase()
    {
        if (timeLeft >=0.5f * timeMax && timeLeft <= 0.7f * timeMax)
        {
            timeMax -= 1;
            Debug.Log("DEV KEY PRESSED");
            staticDataTrack.AddScore(10);
            scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();
            Time.timeScale = 0;
        }
        else
        {
            staticDataTrack.AddScore(-5);
        }
    }

}

