using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBarSpawner : MonoBehaviour {

    public GameObject go;
    public int NumberOfChars;
    public int NumberOfWords;

    List<GameObject> gos;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < NumberOfWords; i++)
        {
            GameObject tmpParent = new GameObject("Word"+i);

            for (int j = 0; j < NumberOfChars; j++)
            {

            }
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
