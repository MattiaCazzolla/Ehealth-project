using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class stimuli_spawner : MonoBehaviour
{
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;
    public List<Color> possibleColors;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;
   
    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject new_Object0;
        GameObject new_Object1;
        GameObject new_Object2;

        if (timeFromSpawn <= 0)
        {
            int rand_object = Random.Range(0, possibleObjects.Count);
            int rand_color = Random.Range(0, possibleColors.Count);
            if (rand_object == 0)
            {
                new_Object0 = Instantiate(possibleObjects[0], new Vector3(-1000, 0, 2500), Quaternion.identity);
                new_Object0.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
            }
            else {
                if(rand_object == 1)
            {
                    new_Object1 = Instantiate(possibleObjects[1], new Vector3(-1000, 0, 2500), Quaternion.identity);
                    new_Object1.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);
                }
                else
                {
                    new_Object2 = Instantiate(possibleObjects[2], new Vector3(-1000, 200, 2500), Quaternion.identity);
                    new_Object2.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[rand_color]);

                }
            }
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}
