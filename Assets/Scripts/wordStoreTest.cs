﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wordStoreTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (staticDataTrack.readOut.Count > 0)
        {
            Debug.Log(staticDataTrack.readOut.Count);
            GetComponent<Text>().text = staticDataTrack.readOut[0];
        }
        Debug.Log(staticDataTrack.readOut.Count);


    }
}
