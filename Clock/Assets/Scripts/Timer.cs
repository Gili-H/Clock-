using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeRemaining = 100;
    private bool timerIsRunning = false;

    private Text timeText;

    private void Start()
    {   
        timerIsRunning = true;
        timeText = GetComponent<Text>();
    }
    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time is up!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        
    }
    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = (string.Format("{0:00}:{1:00}", minutes, seconds));
    }
}
