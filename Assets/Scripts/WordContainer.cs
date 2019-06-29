using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    NOUN,
    VERB,
    ADJECTIVE,
    ADVERB
}

public class WordContainer : MonoBehaviour {

    [System.Serializable]
    public struct Container
    {
        public string name;
        public Type type;
    }

    public Container[] wordCont;

    //Redurn random work of Type
    Container GetRandomWord(Type type)
    {
        Container temp = wordCont[Random.Range(0, wordCont.Length - 1)];
        if (temp.type == type)
        {
            return temp;
        }
        else
        {
            GetRandomWord(type);
        }

        //It should never reach this point
        Container empty = new Container();
        return empty;
    }

    //Return any random word
    Container GetRandomWord()
    {
        return wordCont[Random.Range(0, wordCont.Length - 1)];
    }
    
}
