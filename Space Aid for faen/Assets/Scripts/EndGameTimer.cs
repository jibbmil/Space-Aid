using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameTimer : MonoBehaviour
{
    int countDownStartValue = 100;
    public Text TimerIU;

    bool gameHasEnded = false;
    void Start()
    {
        countDowntimer();
    }

    void countDowntimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            TimerIU.text = "Timer: " + spanTime.Minutes + " : " + spanTime.Seconds;
            
            countDownStartValue--;
            Invoke("countDowntimer", 1.0f);
        }
        else
        {
            EndGame();
         
        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene("spillslutt");
        }
       
    }

   
        
}
        


