using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    
    public float ScrollSpeed;
    public bool scroll = true;
    private Material BackgroundMaterial;
    public Pause pauza;

    private void Awake()
    {
        BackgroundMaterial = GetComponent<Renderer>().material;
        
    }

    private void FixedUpdate()
    {
        if (!pauza.Alive)
        {
            scroll = false;
        }
        if (scroll)
        {
            Vector2 offset = new Vector2(ScrollSpeed * Time.time, 0);
            BackgroundMaterial.mainTextureOffset = offset;
        }

        

    }
}
