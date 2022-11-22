using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand_movement : MonoBehaviour
{
    public float speed = 500;
    public float minx = -1800;
    public float spawn_coord = 3600;

    void Update()
    {
        transform.Translate(Vector3.left*(speed* Time.deltaTime));
        if (transform.position.x <= minx)
        {
            transform.position = new Vector3(spawn_coord, transform.position.y, transform.position.z);
        }
    }
}
