using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameTimer : MonoBehaviour
{
    int countDownStartValue = 60;
    public Text TimerIU;
    public GameObject PauseMenuUI;

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
            TimerIU.text = "Lokal katastrofe " + spanTime.Minutes + " : " + spanTime.Seconds;
            
            countDownStartValue--;
            Invoke("countDowntimer", 1.0f);
        }
        else
        {
            EndGame();
            Cursor.lockState = CursorLockMode.Confined;

        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            PauseMenuUI.SetActive(true);
        }
       
    }

   
        
}
        


