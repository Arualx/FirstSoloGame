using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public PlayerMovement move;

    private void Awake()
    {
        move = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        text.text = "" + move.score;
    }
}
