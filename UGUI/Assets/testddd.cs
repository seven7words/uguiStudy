using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class testddd : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.LogError(eventData);
        // StartCoroutine("LongPress")
    }

    void OnMouseDown()
    {
        Debug.LogError("OnMouseDown");
    }

    void OnMouseUpAsButton()
    {
        Debug.LogError("OnMouseUpAsButton");
    }

    void OnMouseUp()
    {
        Debug.LogError("OnMouseUp");
    }

    void OnMouseDrag()
    {
        Debug.LogError("OnMouseDrag");
    }

    void OnMouseOver()
    {
        Debug.LogError("OnMouseOver");
    }

    void OnMouseExit()
    {
        Debug.LogError("OnMouseExit");
    }

    void OnMouseEnter()
    {
        Debug.LogError("OnMouseEnter");
    }
    
}
