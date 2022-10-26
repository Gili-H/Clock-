using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour
{  
    
    [SerializeField]
    private int playerCharacter;

    public int PlyerCharacter
    {
        get { return playerCharacter; }
        set { playerCharacter = value; }
    }

    private bool onClick;


    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }


    public void Choose1Character()
    {
        playerCharacter = 1;
        onClick = true;
    }

    public void Choose2Character()
    {
        playerCharacter = 2;
        onClick = true;
    }

    public void Choose3Character()
    {
        playerCharacter = 3;
        onClick = true;
    }


    private bool isPaused = false;
    public void StateOfGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        onClick = true;
    }
    
    public void Exit()
    {
        Application.Quit();
    }
    
}
