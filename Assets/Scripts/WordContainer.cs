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

    //[System.Serializable]
    public struct Container
    {
        public Container(string name, Type type)
        {
            this.name = name;
            this.type = type;
        }
        public string name;
        public Type type;
    }

    //Put in as a seperate file as data
    public Container[] wordCont = {
        new Container("Kill", Type.VERB),
        new Container("Speed", Type.NOUN),
        new Container("Grow", Type.VERB),
        new Container("Cool", Type.ADJECTIVE),
        new Container("Strong", Type.ADJECTIVE),
        new Container("Sweet", Type.ADJECTIVE),
        new Container("C++", Type.NOUN),
        new Container("C#", Type.NOUN),
        new Container("Store", Type.VERB),
        new Container("Control", Type.VERB),
        new Container("Flake", Type.NOUN),
        new Container("Trolley", Type.NOUN),
    };

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
            GetRandomWord(type);
        }

        //It should never reach this point
        Container empty = new Container();
        return empty;
    }

    //Return any random word
    public Container GetRandomWord()
    {
        return wordCont[Random.Range(0, wordCont.Length - 1)];
    }
    
}
