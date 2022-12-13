using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class stimuli_spawner : MonoBehaviour
{
    GameObject new_Object;
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;
    public List<Color> possibleColors;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    public float delayBeforeLoading = 5;
    private float timeElapsed;

    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeFromSpawn <= 0)
        {
            int rand_object = Random.Range(0, possibleObjects.Count);
            int rand_color = Random.Range(0, possibleColors.Count);
            if (rand_object == 0)
            {
                new_Object = Instantiate(possibleObjects[0], new Vector3(-1750, 10, 2700), Quaternion.Euler(13.124f,90f,0f));
                new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
            }
            else {
                if(rand_object == 1)
            {
                    new_Object = Instantiate(possibleObjects[1], new Vector3(-1625, 155.52f, 2700), Quaternion.Euler(23.185f, 107.98f, 8.378f));
                    new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
                }
                else
                {
                    new_Object = Instantiate(possibleObjects[2], new Vector3(-1750, 200, 2700), Quaternion.Euler(75.113f, -87.52f, 7.616f));
                    new_Object.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);

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
    }
}
