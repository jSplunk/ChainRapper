using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentance : MonoBehaviour {

    List<Blank> allBlanks;

	// Use this for initialization
	void Start () {
        Blank[] tmp = GetComponentsInChildren<Blank>();

        for(int i = 0; i < tmp.Length; i++)
        {
            allBlanks.Add(tmp[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool isSentanceComplete()
    {

        int NumberOfBlanks = allBlanks.Capacity;
        int BlanksFilled = 0;


        foreach (Blank b in allBlanks)
        {
            if (b.isFilled)
            {
                BlanksFilled++;
            }
        }

        if (BlanksFilled == NumberOfBlanks)
        {
            return true;
        }

        return false;
    }
}
