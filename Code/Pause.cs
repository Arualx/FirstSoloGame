using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private float timer = 2f;
    public float time;
    public bool Alive = true;
    public bool Paused;
    public GameObject Score;
    public GameObject pauza;
    public GameObject Ded;

    void Update()
    {
        if (Alive)
        {
            if (Input.GetKeyDown(KeyCode.Escape)) Paused = !Paused;

            if (Paused)
            {
                Time.timeScale = 0;
                pauza.SetActive(true);
                Score.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                pauza.SetActive(false);
                Score.SetActive(true);
            }
        }
        else {
            time += Time.deltaTime;
            if (time > timer)
            {
                Time.timeScale = 0;
                pauza.SetActive(false);
                Score.SetActive(false);
                Ded.SetActive(true);
            }
            
        }
    }
    public void Unpoz()
    {
        Paused = false;
    }
}
