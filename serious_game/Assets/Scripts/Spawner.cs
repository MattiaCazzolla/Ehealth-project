using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawn <= 0)
        {
            int rand_position = Random.Range(0, possiblePositions.Count);
            int rand_object = Random.Range(0, possibleObjects.Count);

            if (rand_object == 2)
            {
                Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(6500, 150, possiblePositions.ElementAt(rand_position)), Quaternion.identity);
            }
            else
            {
                Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(6500, 0, possiblePositions.ElementAt(rand_position)), Quaternion.identity);
            }

            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}