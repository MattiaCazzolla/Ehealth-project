using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    private float increment;
    public Vector3 currentPos;
    private GameManager gameManager;

    private void Awake()
    {
        currentPos = transform.position;
        Time.fixedDeltaTime = 0.1f;
    }

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && currentPos != new Vector3(-1600,0,2500))
        {
            increment = 500;
            gameObject.transform.position = new Vector3(-1600, 0, currentPos.z + increment);
            currentPos = gameObject.transform.position;
            increment = 0;
            gameManager.reactionTime = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow) && currentPos != new Vector3(-1600, 0,1500))
        {
            increment = -500;
            gameObject.transform.position = new Vector3(-1600, 0, currentPos.z + increment);
            currentPos = gameObject.transform.position;
            increment = 0;
            gameManager.reactionTime = 0;
        }

    }
}
