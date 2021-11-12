using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private static bool pause = false;

    public GameObject PauseMenuUI;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
         if (pause)
            {
                Resume();
            }
         else
            {
                Pause();
            }
            
        }

         void Resume ()
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            pause = false;
        }

        void Pause()
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            pause = true;
        }

     

    }

  
   
}
