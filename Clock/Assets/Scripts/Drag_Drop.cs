using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{


    //private float RotationSpeed = 0.2f;

    //[SerializeField]
    //private GameObject tzir;

    //[SerializeField]
    //private float angle;
    //public float Angle
    //{
    //    get { return angle; }
    //    set { angle = value; }
    //}


    private float RotationSpeed = 0.2f;

    [SerializeField]
    private GameObject tzir;

    [SerializeField]
    private float angle;
    public float Angle
    {
        get { return angle; }
        set { angle = value; }
    }


    [SerializeField]
    private Canvas canvas;

    private CanvasGroup canvasGroup;
    
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        //rectTransform.eulerAngles = new Vector3(0, 0, 0);
        float rotX = Input.GetAxis("Mouse Y") * RotationSpeed;
        tzir.transform.RotateAround(Vector3.forward, rotX);

        angle = gameObject.transform.rotation.eulerAngles.z;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        Debug.Log("End Drag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
    }
}

