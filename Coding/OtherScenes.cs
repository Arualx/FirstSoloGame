using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherScenes : MonoBehaviour
{
    public void GoToRun()
    {
        SceneManager.LoadScene("InfiniteRunner");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
