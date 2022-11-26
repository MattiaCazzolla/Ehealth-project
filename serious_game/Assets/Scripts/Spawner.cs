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

            Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500), Quaternion.identity);

            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}