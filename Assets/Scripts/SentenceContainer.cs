using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SentenceContainer : MonoBehaviour {

    public string[] sentences = new string[100];
    //{
    //    "My name’s Chain the _____",
    //    "I’m not just some _____",
    //    "Surrounded by a world of _____",
    //    "Nothing left to see but _____",

    //    "Not living a life too _____",
    //    "All I eat is _____",
    //    "You thought Chernobyl was _____",
    //    "Well, _____ ",

    //    "A gorgeous view of _____",
    //    "Is now just a land of _____",
    //    "But all’s not over, until humanity _____",
    //    "For we can still _____"
    //};

    public List<List<string>> words = new List<List<string>>
    {
        new List<string>
        {
            "rapper", "hound", "loner"
        },
        new List<string>
        {
            "snapper", "dapper", "clapper", "crapper", "sound", "moaner"
        },
        new List<string>
        {
            "grand", "class", "posh", "clean"
        },
        new List<string>
        {
            "beans in cans", "radioactive grass", "wasteland ass", "hogwash", "way obscene","trash at hand"
        },

    };

    public float[] rangeMin = new float[]
    {
        0.77f,
        0.71f,
    };


    public float[] rangeMax = new float[]
    {
        1f,
        0.95f,

    };
}
