using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PreefabsZum : MonoBehaviour
{
    
    private Pause pauza;
    private Rigidbody2D rb;
    private void Start()
    {
        pauza = GameObject.Find("Canvas").GetComponent<Pause>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (!pauza.Alive)
        {
            Destroy(rb);
            Destroy(GetComponent<DestoryAfterTime>());
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            pauza.Alive = false;
            
        }
    }
}
