using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    adjective,
    noun,
}

public class WordContainer : MonoBehaviour {

    [System.Serializable]
    public struct Container
    {
        public string name;
        public Type type;
    }

    public Container[] wordCont;
    
}
