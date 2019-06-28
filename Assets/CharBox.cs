using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharBox : MonoBehaviour {

    public int Size;
    public Text sizeOfWord;
    Image newImage;
    public GameObject go;
    Image goImage;
    RectTransform rectTransform;

	// Use this for initialization
	void Start () {

        newImage = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();

        sizeOfWord.text = Size.ToString();
        for (int i = 0; i < Size-1; i++)
        {
            Instantiate(go, GetComponentsInParent<Transform>()[1]);

            Image img = go.GetComponent<Image>();

            img.transform.position = new Vector2(0, -100.0f);

            float imgX = 20.0f * (i+1);

            img.transform.position = new Vector2(imgX, img.transform.position.y);

            //float imgX = img.rectTransform.rect.x;
            //float imgY = img.rectTransform.rect.y;

            //imgY = newImage.rectTransform.rect.y;

            

            //float imageX;

            //imageX = newImage.rectTransform.rect.width / 2;

            //float goImageX = go.GetComponent<Image>().rectTransform.rect.x;

            //goImageX += imageX;

        }

        //if (Size > 1)
        //{
        //    float sizeOfCharBox = GetComponent<RectTransform>().rect.width;
        //    float sizeOfWordX = sizeOfWord.rectTransform.rect.x;

        //    sizeOfWordX = sizeOfCharBox / 2;
        //}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
