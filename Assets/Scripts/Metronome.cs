using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
    private float timeRemaining;
    private bool flag; //signals beggining or end of the timer, decides on direction of the slider
    public Slider slider;
    public float timerMax;
    public float timerSpeed;

    void Update()
    {
        slider.value = CalculateSliderValue();

        //moves slider from right to left
        if (timeRemaining >= timerMax)
        {
            timeRemaining = timerMax;
            flag = false;
        }
        else if (flag == true)
        {
            timeRemaining += Time.deltaTime * timerSpeed;
        }

        //moves slider from left to right
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            flag = true;
        }
        else if (timeRemaining > 0 && flag == false)
        {
            timeRemaining -= Time.deltaTime * timerSpeed;
        }

        if (Input.GetKeyDown("space"))
        {
            print("ATTACK!");
            print(timeRemaining);

            checkPhase();
        }


        //Debug.Log(timeRemaining); //displays timeRemaining values in the debug log in unity, delete later
    }

    float CalculateSliderValue()
    {
        return (timeRemaining / timerMax);
    }

    //for testing, displays a message when time was between given values
    void checkPhase()
    {
        if (timeRemaining >= 14.5f && timeRemaining <= 15.5f)
        {
            print("CRITICAL HIT!");
        }
        if (timeRemaining >= 64.5f && timeRemaining <= 65.5f)
        {
            print("CRITICAL HIT!");
        }
    }
}