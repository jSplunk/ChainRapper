using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//-------------------------------------
public class WordContainer : MonoBehaviour {

    public enum Type
    {
        SENT1,
        SENT2,
        SENT3,
        SENT4,
        SENT5
    }

    //-------------------------------------
    public enum Verse
    {
        VER1,
        VER2,
        VER3,
        VER4,
        VER5,
        VER6
    }

    [System.Serializable]
    public struct Container
    {
        public string name;
        public Type type;
    }

    public int meh = 0;

    //Put in as a seperate file as data
    public List<Container> wordCont = new List<Container>();
    List<Container> wordArr = new List<Container>();

    //Redurn random work of Type
    public Container GetRandomWord(Type type)
    {

        for (int i = 0; i < wordCont.Count; i++)
        {
            if (wordCont[i].type == type)
            {
                wordArr.Add(wordCont[i]);
            }
        }

        //Container temp = wordArr[Random.Range(0, wordArr.Count - 1)];
        //foreach(Container o in wordArr)
        //{
        //    wordCont.Remove(o);
        //}



        ////Container temp1 = temp;
        //if (temp.type == type)
        //{
        //    //wordCont.Remove(temp);
        //    return temp;

        //}
        //else
        //{
        //    return GetRandomWord(type);
        //}
        Container temp = wordArr[meh];
        meh++;


        return temp;
    }

    //Return any random word
    public Container GetRandomWord()
    {
        return wordCont[Random.Range(0, wordCont.Count - 1)];
    }
    
}
