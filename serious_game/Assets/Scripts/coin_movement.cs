using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_movement : MonoBehaviour
{
    public float speed = 500;

    void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));

        if (transform.position.x < -2600)
        {
           Destroy(gameObject);
        }
 
    }
}
