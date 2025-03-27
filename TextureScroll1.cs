using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll1 : MonoBehaviour
{
    public Spawner script;
    float ScrollSpeed;
    float delay;
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
            float curSpeed = ScrollSpeed;
            ScrollSpeed = script.Speed / 19;
            delay += ScrollSpeed * Time.time - curSpeed * Time.time;
            Vector2 offset = new Vector2(ScrollSpeed * Time.time - delay, 0);
            BackgroundMaterial.mainTextureOffset = offset;
        }

        

    }
}
