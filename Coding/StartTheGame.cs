using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour
{
    public void GoToSceneRun()
    {
        SceneManager.LoadScene("Run");
    }
}
