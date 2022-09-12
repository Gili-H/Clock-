using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.parent = null;
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().eulerAngles = GetComponent<RectTransform>().eulerAngles;
            eventData.pointerDrag.transform.parent = transform;
        }
        
    }
}
