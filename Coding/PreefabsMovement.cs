using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrefabsMovement : MonoBehaviour
{
    private Pause penguin;
    private Rigidbody2D rb;

    private void Awake()
    {
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            penguin.penguinAlive = false;
        }
    }

    private void Update()
    {
        if(!penguin.penguinAlive)
        {
            Destroy(rb);
            Destroy(GetComponent<DestoryObstacles>());
        }
    }

}
