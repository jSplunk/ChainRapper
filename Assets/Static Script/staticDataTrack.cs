using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticDataTrack {

    public static int score;

    public static void AddScore(int updatedScore)
    {
        score = score + updatedScore;
    }

    public static int GetScore()
    {
        return score;
    }

}
