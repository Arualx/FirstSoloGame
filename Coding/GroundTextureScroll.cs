using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTextureScroll : MonoBehaviour
{
    public Spawner spawner;
    public Pause penguin;

    public float scrollSpeed;
    private float delay;
    private Material backgroundMaterial;
    private float currentSpeed;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }

    private void FixedUpdate()
    {
        if (penguin.penguinAlive)
        {
            Scroll();
        }
    }

    private void Scroll()
    {
        currentSpeed = scrollSpeed;
        scrollSpeed = spawner.prefabSpeed / 19;
        delay += scrollSpeed * Time.time - currentSpeed * Time.time;
        Vector2 offset = new Vector2(scrollSpeed * Time.time - delay, 0);
        backgroundMaterial.mainTextureOffset = offset;
    }

}
