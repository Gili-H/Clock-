using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    private Display_Time display_Time;
    private int hour;

    [SerializeField]
    private Transform canvas;
    [SerializeField]
    private Transform tzir;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
        
            eventData.pointerDrag.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
            eventData.pointerDrag.GetComponent<RectTransform>().eulerAngles = GetComponent<RectTransform>().eulerAngles;
            
            
            int a = (int)eventData.pointerDrag.transform.parent.localEulerAngles.z;
            
            a = 360 - a;
            Debug.Log(a);

            float w = Mathf.Abs(a) / 30f;
            hour = display_Time.Hour;
            if (w == hour)
            {
                Debug.Log("hour is correct");
            }

        }

    }
}

