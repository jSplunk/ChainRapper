using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticDataTrack {

    public static int score;
    public static bool badScore;
    public static int chain = 0;
    private static int highestChain = 0;
    //static List<string> wordChoices = new List<string>();

    public static List<string> readOut = new List<string>();

    public static void AddScore(int updatedScore)
    {

        score += updatedScore;
        if(score < 0)
        {
            score = 0;
        }
        //if ((score - updatedScore) <= 0)
        //{
        //    //score = score + updatedScore;
        //    score = 0;
        //}
        //else
        //{
        //    score += updatedScore;
        //}
    }

    public static int GetScore()
    {
        return score;
    }

    public static void SetBadScore(bool score)
    {
        badScore = score;
    }

    public static void SetChain(int updatedChain)
    {
        //adds one to the chain count
        chain = chain + updatedChain;
        //updates the highest chain earned
        if (chain > highestChain)
        {
            highestChain = chain;
        }
    }

    public static void ResetChain()
    {
        //reset the chain count
        chain = 0;
    }

    public static int GetChain()
    {
        return chain;
    }

    public static int GetHighestChain()
    {
        return highestChain;
    }

    public static void AddToWordList(string word)
    {
        readOut.Add(word);
        Debug.Log(word);
    }
}
