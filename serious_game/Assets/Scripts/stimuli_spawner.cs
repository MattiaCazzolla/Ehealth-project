using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class stimuli_spawner : MonoBehaviour
{
    GameObject new_Object;
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;
    public List<Color> possibleColors;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    public float delayBeforeLoading = 4;
    private float timeElapsed;

    private int rand_object;
    private int rand_color;
    public int events = 0;

    public int current_type;
    public Color current_color;
    public int rand_state;

    private GameManager gameManager;
    public TextMeshProUGUI matchText;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == 0)
        {
            possibleColors[0] = Color.black;
            possibleColors[1] = Color.black;
            possibleColors[2] = Color.black;
        }
        else
        {
            if (gameManager.colorblind == 0)
            {
                possibleColors[0] = new Color(0.03025982f, 0.1303901f, 0.9433962f);
                possibleColors[1] = new Color(1, 0, 0);
                possibleColors[2] = new Color(0.08958072f, 1f, 0.05094329f);
            }
            else if (gameManager.colorblind == 1)
            {
                possibleColors[0] = new Color(0.067f, 0.659f, 0.667f);
                possibleColors[1] = new Color(0.988f, 0.49f, 0.043f);
                possibleColors[2] = new Color(0.482f, 0.518f, 0.561f);
            }
        }

        if (timeFromSpawn <= 0)
        {
            rand_object = Random.Range(0, possibleObjects.Count);
            rand_color = Random.Range(0, possibleColors.Count);
            rand_state = Random.Range(0, 2);
            events += 1;

            if (rand_object == 0)
            {
                new_Object = Instantiate(possibleObjects[0], new Vector3(-1750, 10, 2700), Quaternion.Euler(13.124f,90f,0f));
                new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
                current_type = 0;
                current_color = possibleColors[rand_color];
            }
            else 
            {
                if(rand_object == 1)
                {
                    new_Object = Instantiate(possibleObjects[1], new Vector3(-1625, 155.52f, 2800), Quaternion.Euler(23.185f, 107.98f, 8.378f));
                    new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
                    current_type = 1;
                    current_color = possibleColors[rand_color];
                }
                else
                {
                    new_Object = Instantiate(possibleObjects[2], new Vector3(-1750, 250, 2700), Quaternion.Euler(75.113f, -87.52f, 7.616f));
                    new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
                    current_type = 2;
                    current_color = possibleColors[rand_color];

                }
            }
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }

        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            Destroy(new_Object);
            timeElapsed = 0;
        }

        if (gameManager.state == 0)
            matchText.text = "Match Shape";
        else if (gameManager.state == 1)
            matchText.text = "Match Color";
        else
        {
            if (rand_state == 0)
                matchText.text = "Match Shape";
            else
                matchText.text = "Match Color";
        }
    }
}
