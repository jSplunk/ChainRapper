using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticDataTrack {

    public static int score;
    public static int chain = 0;
    private static int highestChain = 0;

    public static void AddScore(int updatedScore)
    {
        if (score > 0)
        {
            score = score + updatedScore;
        }
    }

    public static int GetScore()
    {
        return score;
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
}
