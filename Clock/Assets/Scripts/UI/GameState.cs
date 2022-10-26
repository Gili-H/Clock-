using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField]
    private Text text;

    public void PauseGame()
    {
        if(isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            text.text = "||";
            
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
            text.text = ">";
        }
        
    }
    public void Exit()
    {
        Application.Quit();
    }





}
