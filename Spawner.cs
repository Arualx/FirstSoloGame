using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerMovement player;
    public Pause penguin;
    public float prefabSpeed;

    [SerializeField] List<GameObject> obstacles = new List<GameObject>();
    [SerializeField] GameObject point;
    [SerializeField] int startSpeed;

    private float whenToSpawn;
    private float timer = 0;
    

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        penguin = GameObject.Find("Canvas").GetComponent<Pause>();
    }

    private void Update()
    {
        if (penguin.penguinAlive)
        {
            timer += Time.deltaTime;
            if (timer >= whenToSpawn)
            {
                whenToSpawn = Random.Range(1.5f, 3f);
                prefabSpeed = startSpeed + player.score * .5f;
                timer = 0;
                GameObject obstacleCreate = Instantiate(obstacles[Random.Range(0, obstacles.Count)], transform.position, Quaternion.identity);
                obstacleCreate.GetComponent<Rigidbody2D>().AddForce(Vector3.left * prefabSpeed, ForceMode2D.Impulse);
                GameObject pointerCreate = Instantiate(point, transform.position + Vector3.right * 2, Quaternion.identity, obstacleCreate.transform);
                pointerCreate.GetComponent<Rigidbody2D>().AddForce(Vector3.left * prefabSpeed, ForceMode2D.Impulse);
            }
        }
        
    }
}
