using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceContainer : MonoBehaviour {
    public string[] sentences = new string[] 
    {
        "Yo, my name is _____",
        "test"
    };

    public float[] rangeMin = new float[]
    {
        0.5f,
        0.25f,
    };

    public float[] rangeMax = new float[]
    {
        0.7f,
        0.5f,
    };
}
