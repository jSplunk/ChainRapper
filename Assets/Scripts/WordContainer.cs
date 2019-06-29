using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    SENT1,
    SENT2,
    SENT3,
    SENT4,
    SENT5
}

public class WordContainer : MonoBehaviour {

    [System.Serializable]
    public struct Container
    {
        public string name;
        public Type type;
    }


    //Put in as a seperate file as data
    public Container[] wordCont;

    //Redurn random work of Type
    public Container GetRandomWord(Type type)
    {
        Container temp = wordCont[Random.Range(0, wordCont.Length - 1)];
        if (temp.type == type)
        {
            return temp;
        }
        else
        {
            return GetRandomWord(type);
        }
    }

    //Return any random word
    public Container GetRandomWord()
    {
        return wordCont[Random.Range(0, wordCont.Length - 1)];
    }
    
}
