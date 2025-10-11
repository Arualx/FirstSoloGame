using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTaken : MonoBehaviour
{
    private Pause penguin;
    private int playerCollider = 0;

    private void Start()
    {
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
    }

    private void Update()
    {
        if (!penguin.penguinAlive)
        {
            Destroy(GetComponent<Rigidbody2D>());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCollider++;
            if(playerCollider == 2)
            {
                collision.gameObject.GetComponent<PlayerMovement>().score += 1;
                playerCollider =  0;

            }
        }
    }
}
