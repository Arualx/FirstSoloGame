using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public int Score;
    public Pause p;

    private bool CanJump = true;
    public float JumpStrenght;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "groun") CanJump = true ;
        GetComponent<Animator>().SetBool("Jump", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "groun") CanJump = false ;
    }
    public void Update()
    {
        if(CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * JumpStrenght, ForceMode2D.Impulse);
        }

        if (!p.Alive)
        {
            gameObject.GetComponent<Animator>().SetBool("Dead",true);
        }

    }

}
