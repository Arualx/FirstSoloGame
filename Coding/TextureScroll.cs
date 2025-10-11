using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    
    public float ScrollSpeed;
    public bool scroll = true;
    private Material BackgroundMaterial;
    public Pause penguin;

    private void Awake()
    {
        BackgroundMaterial = GetComponent<Renderer>().material;
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
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
        Vector2 offset = new Vector2(ScrollSpeed * Time.time, 0);
        BackgroundMaterial.mainTextureOffset = offset;
    }
}
