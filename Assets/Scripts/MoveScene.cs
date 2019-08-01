using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(startScene());
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
	}

    IEnumerator startScene()
    {


        yield return new WaitForSeconds(70f);
        SceneManager.LoadScene(1);
    }
}
