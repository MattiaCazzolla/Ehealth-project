using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand_movement : MonoBehaviour
{
    public float speed = 500;
    public float minx = -1800;
    public float spawn_coord = 3600;
    public float xstart;

    void Start()
    {
       xstart = transform.position.x;
    }
    void Update()
    {
        transform.Translate(Vector3.left*(speed* Time.deltaTime));
        if (transform.position.x <= minx)
        {
            transform.position = new Vector3(spawn_coord-xstart, transform.position.y, transform.position.z);
        }
    }
}