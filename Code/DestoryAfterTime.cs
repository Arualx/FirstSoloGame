using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAfterTime : MonoBehaviour
{
    public float timer;
    public float time;

    public void Update()
    {
        timer += Time.deltaTime;

        if(timer >= time)
        {
            Destroy(gameObject);
        }
    }
}
