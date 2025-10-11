using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObstacles : MonoBehaviour
{
    private void Update()
    {
        if(gameObject.transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
