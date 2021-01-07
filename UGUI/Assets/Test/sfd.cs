using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class sfd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DebugAllPosition();
        PositionAndLocalPosition();
    }

    void DebugAllPosition()
    {
        RectTransform rect = GetComponent<RectTransform>(); 
        Debug.Log("position:\t\t" + transform.position);
        Debug.Log("localPosition:\t\t" + transform.localPosition);
        Debug.Log("anchoredPosition:\t\t" + rect.anchoredPosition);
        Debug.Log("anchoredPosition3D:\t\t" + rect.anchoredPosition3D);
    }
    
    void PositionAndLocalPosition()
    {
        Debug.Log("position:\t\t" + transform.position);

        Transform t = transform;
        Vector3 pos = Vector3.zero;
        while(t != null)
        {
            pos += t.localPosition;
            t = t.parent;
        }
        Debug.Log("localPositon sum:\t" + pos);
    }
}
