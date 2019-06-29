using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WordDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{

    //test
    [SerializeField] private bool match;
    [SerializeField] GameObject newParent;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //If values match
        //change parent to panel with matching value
        //center in the local position of the new panel
        if(match)
        {
            transform.parent = newParent.transform;
            newParent.AddComponent<WordDropHandler>();
            transform.localPosition = Vector3.zero;

        }
        else
        {
            transform.localPosition = Vector3.zero;
        }

        //else go back to original parent rect

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
