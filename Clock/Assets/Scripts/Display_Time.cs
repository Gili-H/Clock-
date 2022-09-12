using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display_Time : MonoBehaviour
{
    
    [SerializeField] 
    private TMP_Text what_hour;
    [SerializeField]
    private TMP_Text what_minute;

    [SerializeField]
    private int hour;
    private int minute;

    private int x;

    //[SerializeField]
    //private GameObject hand_1;
    //private Transform transform_h_1;

    //[SerializeField]
    //private GameObject hand_2;
    //private Transform transform_h_2;

    [SerializeField]
    private Hands_Controller hands_Controller_1;

    [SerializeField]
    private Hands_Controller hands_Controller_2;

    [SerializeField]
    private float angle_h1;


    [SerializeField]
    private float angle_h2;

    private void Start()
    {
        //transform_h_1 = gameObject.GetComponent<Transform>();
        //transform_h_2 = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        angle_h1 = hands_Controller_1.Angle;
        //angle_h1 = transform.rotation.eulerAngles.z;
        int a = (int)angle_h1;

        float w = Mathf.Abs(a) / 30f;

        if (w == hour)
        {
            Debug.Log("hour");
        }

        //angle_h2 = transform.rotation.eulerAngles.z;
        angle_h2 = hands_Controller_2.Angle;
        int b = (int)angle_h2;

        float u = Mathf.Abs(a) / 5f;

        if (u == minute)
        {
            Debug.Log("minute");
        }


    }
    public void DisplayOnlyHours()
    {
        hour = Random.Range(01, 12);
        what_hour.text = hour.ToString();
        if (hour < 10)
        {
            what_hour.text = "0" + hour.ToString();
        }
        

        minute = 00;
        what_minute.text = minute.ToString();
    }

    public void Display5Multiple()
    {
        minute = Random.Range(0, 60);
        x = minute % 5;
        minute = minute - x;
        what_minute.text = minute.ToString();
        if (minute < 10)
        {
            what_minute.text = "0" + minute.ToString();
        }


        hour = Random.Range(1, 12);
        what_hour.text = hour.ToString();
        if (hour < 10)
        {
            what_hour.text = "0" + hour.ToString();
        }

    }   
    
    public void DisplayRegular()
    {
        minute = Random.Range(0, 60);
        what_minute.text = minute.ToString();
        if (minute < 10)
        {
            what_minute.text = "0" + minute.ToString();
        }

        hour = Random.Range(1, 12);
        what_hour.text = hour.ToString();
        if (hour < 10)
        {
            what_hour.text = "0" + hour.ToString();
        }
    }

    
}
