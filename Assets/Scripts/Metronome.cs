using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
    private float timeRemaining;
    private bool flag; //signals beggining or end of the timer, decides on direction of the slider
    private Slider slider;
    private float timerMax = 10f;
    [SerializeField] private float timerSpeed;
    private float MiddleSectionSize = 0.6f;
    private float OutsideSectionSize = 1.5f;


    private void Start()
    {
        slider = GetComponent<Slider>();
    }
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

        if(Input.GetKeyDown(KeyCode.W))
        {
            CheckPhase();
        }

    }

    float CalculateSliderValue()
    {
        return (timeRemaining / timerMax);
    }

    //for testing, displays a message when time was between given values
    public void CheckPhase()
    {
        if (timeRemaining >= (timerMax*0.5)-MiddleSectionSize && timeRemaining <= (timerMax*0.5)+MiddleSectionSize)
        {
            print("Middle Section!");
            timerSpeed += 1;
        }
        else if (timeRemaining >= (timerMax * 0.5) - OutsideSectionSize && timeRemaining <= (timerMax * 0.5) + OutsideSectionSize)
        {
            print("Outside Section!");
            timerSpeed += 0.5f;
        }
        else
        {
            if (timerSpeed >= 3f)
            {
                timerSpeed -= 0.5f;
            }
        }
    }
}