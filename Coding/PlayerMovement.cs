using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int score = 0;
    public Pause penguin;

    private bool canJump = false;
    [SerializeField] float jumpStrenght;

    private void Awake()
    {
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
    }

    //able to jump only while on the ground
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ground")) canJump = true ;
        GetComponent<Animator>().SetBool("Jump", false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground")) canJump = false;
    }

    private void Update()
    {

        //jump mechanic
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpStrenght, ForceMode2D.Impulse);
        }

        //death
        if (!penguin.penguinAlive)
        {
            gameObject.GetComponent<Animator>().SetBool("Dead",true);
        }

    }

}
