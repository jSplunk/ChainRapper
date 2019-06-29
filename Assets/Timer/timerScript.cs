using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    Slider timeLeftBar;
    public float timeMax = 10.0f;
    float timeLeft;
    public GameObject timesUpText;
    public GameObject scoreText;
    

    void Start()
    {
        timeLeftBar = GetComponent<Slider>();
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = 0;
        Debug.Log("Starting timer");
    }

    void Update()
    {
        if(timeLeft < timeMax)
        {
            timesUpText.SetActive(false);
            timeLeft = timeLeft + Time.deltaTime;
            Debug.Log(timeLeft);
            timeLeftBar.value = timeLeft;
            Debug.Log("Time Increase");
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("DEV KEY PRESSED");
            staticDataTrack.AddScore(Mathf.RoundToInt(timeMax - timeLeftBar.value));
            scoreText.GetComponent<Text>().text = "SCORE: " + staticDataTrack.GetScore();
            Time.timeScale = 0;
        }
    }

}

