using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TreasureMovement : MonoBehaviour
{
    private float increment;
    public Vector3 currentPos;


    private void Awake()
    {
        currentPos = transform.position;
        Time.fixedDeltaTime = 0.10f;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && currentPos != new Vector3(2500,115,2500))
        {
            increment = 750;
            gameObject.transform.position = new Vector3(currentPos.x + increment, 115, 2500);
            currentPos = gameObject.transform.position;
            increment = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow) && currentPos != new Vector3(1000, 115, 2500))
        {
            increment = -750;
            gameObject.transform.position = new Vector3(currentPos.x + increment, 115, 2500);
            currentPos = gameObject.transform.position;
            increment = 0;
        }

    }
}
