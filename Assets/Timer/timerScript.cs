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
    

    void Start()
    {
        timeLeftBar = GetComponent<Slider>();
        timeLeft = timeMax;
        timeLeftBar.maxValue = timeMax;
        timeLeftBar.value = timeLeft;
        Debug.Log("Starting timer");
    }

    void Update()
    {
        if(timeLeft > 0)
        {
            timesUpText.SetActive(false);
            timeLeft = timeLeft - Time.deltaTime;
            Debug.Log(timeLeft);
            timeLeftBar.value = timeLeft;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }

}

