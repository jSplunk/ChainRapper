using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SentenceContainer : MonoBehaviour
{

    public string[] sentences = new string[]
    {
        //Verse 1
        "My name’s Chain the ",
        "I’m not just some ",
        "Not living a life too ",
        "All I eat is ",

        //Verse 2
        "Surrounded by a world of ",
        "Nothing left to see but ",
        "You thought Chernobyl was ",
        "Well, ",

        //Verse 3
        "A gorgeous view of ",
        "Is now just a land of ",
        "But all’s not over, until humanity ",
        "For we can still ",

        //Verse 4
        "As I stand, I see toxic ",
        "Just a glimpse already ",
        "So now I ask for your ",
        "Mother nature's wounds we shall "
    };

    public List<List<string>> words = new List<List<string>>
    {

    //Verse 1
        new List<string>
        {
            "rapper", "hound", "loner",
        },
        new List<string>
        {
            "crapper", "sound", "moaner",
        },
        new List<string>
        {
            "grand", "class", "clean",
        },
        new List<string>
        {
            "trash at hand", "wasteland ass", "way obscene",
        },

        //Verse 2
        new List<string>
        {
           "ash", "ruin", "end",
        },
        new List<string>
        {
            "the backlash", "to be doin'", "mend",
        },
        new List<string>
        {
            "bad", "the end", "ruination",
        },
        new List<string>
        {
            "my diapers are second hand", "too bad we didn't amend", "we ruined more than just a nation",
        },

        //Verse 3
        new List<string>
        {
            "past life's", "grassy hills", "mother nature",
        },
        new List<string>
        {
           "mass crimes", "devil's grills", "hellish danger",
        },
        new List<string>
        {
           "lives", "stands", "holds on",
        },
        new List<string>
        {
            "fix this", "make amends", "have a new dawn",
        },

        //Verse 4
        new List<string>
        {
            "rivers", "wastes", "air",
        },
        new List<string>
        {
            "aid", "help", "hand",
        },
        new List<string>
        {
            "fade", "tend", "mend",
        },
    };

    //public float[] rangeMin = new float[]
    //{
    //    0.838f,
    //};


    //public float[] rangeMax = new float[]
    //{
    //    1f,


    //};
}