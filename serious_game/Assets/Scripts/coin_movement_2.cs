using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_movement_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1000;
    void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));

    }
}

