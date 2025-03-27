using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTaken : MonoBehaviour
{
    public Pause pauza;
    public int bod;

    private void Start()
    {
        pauza = GameObject.Find("Canvas").GetComponent<Pause>();
    }

    public void Update()
    {
        if (!pauza.Alive)
        {
            Destroy(GetComponent<Rigidbody2D>());
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Žena") Console.WriteLine("Point Not Taken");
        if (collision.tag == "Player") {
            bod++;
            if(bod == 2)
            {
                collision.gameObject.GetComponent<PlayerJump>().Score += 1;
                bod =  0;

            }
        }
    }
}
