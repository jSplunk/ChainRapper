using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceContainer : MonoBehaviour {
    public string[] sentences = new string[] 
    {
        "My name’s Chain the _____",
        "I’m not just some _____",
        "Surrounded by a world of _____",
        "Nothing left to see but _____",

        "Not living a life too _____",
        "All I eat is _____",
        "You thought Chernobyl was _____",
        "Well, _____ ",

        "A gorgeous view of _____",
        "Is now just a land of _____",
        "But all’s not over, until humanity _____",
        "For we can still _____"
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
