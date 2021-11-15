using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Forest");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartForest()
    {
        SceneManager.LoadScene("Forest");
    }

    public void RestartDessert()
    {
        SceneManager.LoadScene("Dessert");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
