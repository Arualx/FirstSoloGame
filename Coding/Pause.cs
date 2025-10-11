using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private float deathTimer = 5f;
    public float timer;

    public bool penguinAlive = true;

    public bool paused;

    [SerializeField] GameObject scoreUI;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject deathMenu;

    private void Update()
    {
        if (penguinAlive)
        {
            if (Input.GetKeyDown(KeyCode.Escape)) paused = !paused;

            if (paused)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                scoreUI.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                scoreUI.SetActive(true);
            }
        }
        else {
            timer += Time.deltaTime;
            if (timer >= deathTimer)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(false);
                scoreUI.SetActive(false);
                deathMenu.SetActive(true);
            }
            
        }
    }
}
