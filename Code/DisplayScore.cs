using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    public PlayerJump pj;

    public void Update()
    {
        text.text = "" + pj.Score;
    }
}
