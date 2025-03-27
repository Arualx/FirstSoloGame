using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Vector3 Velocity;
    public float jumForce;
    public Rigidbody2D rb;
    public bool CanJump;
    public Animator anim;
    public bool Moving;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForcePlatformer();
    }

    public void MoveTranslate()
    {
        Velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D)) Velocity += new Vector3(1, 0,0);
        if (Input.GetKey(KeyCode.A)) Velocity += new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.W)) Velocity += new Vector3(0, 1, 0);
        if (Input.GetKey(KeyCode.S)) Velocity += new Vector3(0, -1, 0);

        transform.Translate(Velocity.normalized * Time.deltaTime);
    }
    public void MoveForce()
    {
        Velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D)) Velocity += new Vector3(1, 0, 0);
        if (Input.GetKey(KeyCode.A)) Velocity += new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.W)) Velocity += new Vector3(0, 1, 0);
        if (Input.GetKey(KeyCode.S)) Velocity += new Vector3(0, -1, 0);

        rb.AddForce(Velocity.normalized);
    }
    public void MoveForcePlatformer()
    {
        Velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D)) Velocity += new Vector3(1, 0, 0);
        if (Input.GetKey(KeyCode.A)) Velocity += new Vector3(-1, 0, 0);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) Moving = true;


        if (Input.GetKeyDown(KeyCode.Space) && CanJump) rb.AddForce(transform.up * jumForce, ForceMode2D.Impulse);

        rb.AddForce(Velocity);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "groun") CanJump = true;
    }
    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "groun") CanJump = false;
    }
}
