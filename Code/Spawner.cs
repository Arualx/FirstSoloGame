using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerJump player;
    private float Timer = 0;
    public float WhenToSpawn;
    public List<GameObject> Obsticles = new List<GameObject>();
    public GameObject Preefab2;
    public int StartSpeed;
    public float Speed;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerJump>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= WhenToSpawn)
        {

            WhenToSpawn = Random.Range(1.5f, 3f);
            Speed = StartSpeed + player.Score * .5f;
            Timer = 0;
            GameObject dis = Instantiate(Obsticles[Random.Range(0, Obsticles.Count)], transform.position, Quaternion.identity);
            dis.GetComponent<Rigidbody2D>().AddForce(Vector3.left * Speed, ForceMode2D.Impulse);
            GameObject dis2 = Instantiate(Preefab2, transform.position + Vector3.right * 2, Quaternion.identity);
            dis2.GetComponent<Rigidbody2D>().AddForce(Vector3.left * Speed, ForceMode2D.Impulse);
        }
    }
}
