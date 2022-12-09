using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovements : MonoBehaviour
{
    private float increment;
    public Vector3 currentPos;


    private void Awake()
    {
        currentPos = transform.position;
        Time.fixedDeltaTime = 0.15f;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && currentPos != new Vector3(-1600,0,2500))
        {
            increment = 500;
            gameObject.transform.position = new Vector3(-1600, 0, currentPos.z + increment);
            currentPos = gameObject.transform.position;
            increment = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow) && currentPos != new Vector3(-1600, 0,1500))
        {
            increment = -500;
            gameObject.transform.position = new Vector3(-1600, 0, currentPos.z + increment);
            currentPos = gameObject.transform.position;
            increment = 0;
        }

    }
}
