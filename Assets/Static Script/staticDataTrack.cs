﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticDataTrack {

    public static int score;
    public static bool badScore;
    public static List<string> readOut = new List<string>();

    public static void isBadScore(bool b)
    {
        badScore = b;
    }

    public static void AddScore(int updatedScore)
    {
        score = score + updatedScore;
    }

    public static int GetScore()
    {
        return score;
    }
}
