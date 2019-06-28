using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBarSpawner : MonoBehaviour {

    public GameObject go;
    int NumberOfChars;

    List<GameObject> gos;

	// Use this for initialization
	void Start () {
        Instantiate(go, transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
